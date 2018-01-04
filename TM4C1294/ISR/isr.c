/*
 * isr.c
 *
 *  Created on: 2016年5月27日
 *      Author: Yi
 */

#include "isr.h"
uint32_t ui32Status;
char rx_num;
uint32_t rx_msg;

#define CMD_Num	20
union DATA_16B data_comb_rx[CMD_Num];
int16 rx_data_index = 0;
signed char *data_comb_ptr = (signed char *)data_comb_rx;

int32_t iir_dc_register = 0;

union DATA_16B data_comb_send[20];

//static const int16_t coeffs[12] =
//{
//    688,
//    1283,
//    2316,
//    3709,
//    5439,
//    7431,
//    9561,
//    11666,
//    13563,
//    15074,
//    16047,
//    16384
//};

static const int16_t lp_coeffs[24] =
{
		-360,   -136,    150,    486,    859,   1248,   1636,   1999,   2319,
		2576,   2757,   2850,   2850,   2757,   2576,   2319,   1999,   1636,
		1248,    859,    486,    150,   -136,   -360
};

static const int16_t hp_coeffs[24] =
{
		791,    960,   1062,   1070,    963,    713,    290,   -355,  -1324,
		-2888,  -6065, -20169,  20169,   6065,   2888,   1324,    355,   -290,
		-713,   -963,  -1070,  -1062,   -960,   -791
};

static const int16_t bp_coeffs[30] =
{
		818,   1151,   1249,   1004,    405,   -448,  -1359,  -2081,  -2392,
		-2156,  -1379,   -214,   1071,   2164,   2790,   2790,   2164,   1071,
		-214,  -1379,  -2156,  -2392,  -2081,  -1359,   -448,    405,   1004,
		1249,   1151,    818
};

static const int16_t bs_coeffs[31] =
{
		-741,  -1221,  -1504,  -1424,   -906,      0,   1107,   2137,   2793,
		2849,   2222,   1009,   -526,  -2018,  -3097,  31407,  -3097,  -2018,
		-526,   1009,   2222,   2849,   2793,   2137,   1107,      0,   -906,
		-1424,  -1504,  -1221,   -741
};

//需要在中断向量表进行注册
void UARTIntHandler(void)
{


    ui32Status = UARTIntStatus(UART0_BASE, true); //get interrupt status

    UARTIntClear(UART0_BASE, ui32Status); //clear the asserted interrupts


    while(UARTCharsAvail(UART0_BASE)) //loop while there are chars
    {
    	rx_num = (signed char)UARTCharGetNonBlocking(UART0_BASE);

    	rx_msg = rx_msg<<8;
    	rx_msg = rx_msg + rx_num;
    	if(rx_msg == 0x40232621)	// @#&! 0x40232621
    	{
    		rx_data_index = 0;
    	}
    	else
    	{
    		data_comb_ptr[rx_data_index] = rx_num;

    		rx_data_index++;
			if (rx_data_index >= CMD_Num * 2)
				rx_data_index = CMD_Num * 2;
    	}


    }
}


void Timer0IntHandler(void)
{
	// Clear the timer interrupt
	TimerIntClear(TIMER0_BASE, TIMER_TIMA_TIMEOUT);

	mcu_temp = mcu_temp_get();
	data_comb_send[0].all = 0;

	adc_voltage_get();
	//data_comb_send[1].all = (ui32ADC0_Sequence1[0] + ui32ADC0_Sequence1[1] + ui32ADC0_Sequence1[2] + ui32ADC0_Sequence1[3]) / 4;
	data_comb_send[1].all = ui32ADC0_Sequence1[0];

	if (data_comb_rx[0].all == 0)
	{
		data_comb_send[2].all = lp_filter(data_comb_send[1].all);
		GPIOPinWrite(GPIO_PORTN_BASE, GPIO_PIN_1|GPIO_PIN_0, 0);
		GPIOPinWrite(GPIO_PORTF_BASE, GPIO_PIN_4|GPIO_PIN_0, 0);
	}
	else if (data_comb_rx[0].all == 1)
	{
		data_comb_send[2].all = hp_filter(data_comb_send[1].all);
		GPIOPinWrite(GPIO_PORTN_BASE, GPIO_PIN_1|GPIO_PIN_0, GPIO_PIN_1);
		GPIOPinWrite(GPIO_PORTF_BASE, GPIO_PIN_4|GPIO_PIN_0, 0);
	}
	else if (data_comb_rx[0].all == 2)
	{
		data_comb_send[2].all = bp_filter(data_comb_send[1].all);
		GPIOPinWrite(GPIO_PORTN_BASE, GPIO_PIN_1|GPIO_PIN_0, GPIO_PIN_0);
		GPIOPinWrite(GPIO_PORTF_BASE, GPIO_PIN_4|GPIO_PIN_0, 0);
	}
	else if (data_comb_rx[0].all == 3)
	{
		data_comb_send[2].all = bs_filter(data_comb_send[1].all);
		GPIOPinWrite(GPIO_PORTN_BASE, GPIO_PIN_1|GPIO_PIN_0, GPIO_PIN_0|GPIO_PIN_1);
		GPIOPinWrite(GPIO_PORTF_BASE, GPIO_PIN_4|GPIO_PIN_0, 0);
	}
	else if (data_comb_rx[0].all == 4)
	{
		data_comb_send[2].all = dc_estimator(&iir_dc_register, data_comb_send[1].all);
		GPIOPinWrite(GPIO_PORTN_BASE, GPIO_PIN_1|GPIO_PIN_0, 0);
		GPIOPinWrite(GPIO_PORTF_BASE, GPIO_PIN_4|GPIO_PIN_0, GPIO_PIN_4);
	}
	else if (data_comb_rx[0].all == 5)
	{
		data_comb_send[2].all = data_comb_send[1].all - dc_estimator(&iir_dc_register, data_comb_send[1].all);
		GPIOPinWrite(GPIO_PORTN_BASE, GPIO_PIN_1|GPIO_PIN_0, GPIO_PIN_1);
		GPIOPinWrite(GPIO_PORTF_BASE, GPIO_PIN_4|GPIO_PIN_0, GPIO_PIN_4);
	}

	data_comb_send[3].all = mcu_temp;

	sci_msg("@#&!");

	UARTCharPut(UART0_BASE, data_comb_send[0].bit.DATAL);
	UARTCharPut(UART0_BASE, data_comb_send[0].bit.DATAH);

	UARTCharPut(UART0_BASE, data_comb_send[1].bit.DATAL);
	UARTCharPut(UART0_BASE, data_comb_send[1].bit.DATAH);

	UARTCharPut(UART0_BASE, data_comb_send[2].bit.DATAL);
	UARTCharPut(UART0_BASE, data_comb_send[2].bit.DATAH);

	UARTCharPut(UART0_BASE, data_comb_send[3].bit.DATAL);
	UARTCharPut(UART0_BASE, data_comb_send[3].bit.DATAH);

//	if(GPIOPinRead(GPIO_PORTN_BASE, GPIO_PIN_0))
//	{
//		GPIOPinWrite(GPIO_PORTN_BASE, GPIO_PIN_0|GPIO_PIN_1, 0);
//	}
//	else
//	{
//		GPIOPinWrite(GPIO_PORTN_BASE, GPIO_PIN_0|GPIO_PIN_1, GPIO_PIN_0|GPIO_PIN_1);
//	}
}


int16_t lp_filter(int16_t sample)
{
    static int32_t buf[32];
    static int offset = 0;
    int32_t z = 0;
    int i;

                                            //Filter hard above a few Hertz,
                                            //using a symmetric FIR.
                                            //This has benign phase
                                            //characteristics */
    buf[offset] = sample;
    for (i = 0;  i < 24;  i++)
        z += lp_coeffs[i] *  (buf[(offset - 23 + i) & 0x1F]);
    offset = (offset + 1) & 0x1F;
    return  z >> 15;
}


int16_t hp_filter(int16_t sample)
{
    static int32_t buf[32];
    static int offset = 0;
    int32_t z = 0;
    int i;

                                            //Filter hard above a few Hertz,
                                            //using a symmetric FIR.
                                            //This has benign phase
                                            //characteristics */
    buf[offset] = sample;
    for (i = 0;  i < 24;  i++)
        z += hp_coeffs[i] *  (buf[(offset - 23 + i) & 0x1F]);
    offset = (offset + 1) & 0x1F;
    return  z >> 15;
}

int16_t bp_filter(int16_t sample)
{
    static int32_t buf[32];
    static int offset = 0;
    int32_t z = 0;
    int i;

                                            //Filter hard above a few Hertz,
                                            //using a symmetric FIR.
                                            //This has benign phase
                                            //characteristics */
    buf[offset] = sample;
    for (i = 0;  i < 30;  i++)
        z += bp_coeffs[i] *  (buf[(offset - 29 + i) & 0x1F]);
    offset = (offset + 1) & 0x1F;
    return  z >> 15;
}

int16_t bs_filter(int16_t sample)
{
	static int32_t buf[32];
	    static int offset = 0;
	    int32_t z = 0;
	    int i;

	                                            //Filter hard above a few Hertz,
	                                            //using a symmetric FIR.
	                                            //This has benign phase
	                                            //characteristics */
	    buf[offset] = sample;
	    for (i = 0;  i < 31;  i++)
	        z += bs_coeffs[i] *  (buf[(offset - 30 + i) & 0x1F]);
	    offset = (offset + 1) & 0x1F;
	    return  z >> 15;
}

int16_t dc_estimator(register int32_t *p, register int16_t x)
{
    /* Noise shaped DC estimator. */
    *p += ((((int32_t) x << 16) - *p) >> 9);
    return (*p >> 16);
}
