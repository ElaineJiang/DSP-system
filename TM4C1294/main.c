#include "includes.h"




uint32 loop = 0;




int main(void)
 {
	sys_init();
	uart_init();

	sci_msg("\r\n");
	sci_msg("UART-init done...... \n\0");

    adc_init();

	while(1)
	{
//		loop++;
//
//		if (loop > 30000)
//			loop = 0;

//		UARTCharPut(UART0_BASE, '@');
//		UARTCharPut(UART0_BASE, '#');
//		UARTCharPut(UART0_BASE, '&');
//		UARTCharPut(UART0_BASE, '!');
//
//		data_comb_send[0].all = loop;
//
//		UARTCharPut(UART0_BASE, data_comb_send[0].bit.DATAL);
//		UARTCharPut(UART0_BASE, data_comb_send[0].bit.DATAH);
//
//		SysCtlDelay(120000 / 3);



//		GPIOPinWrite(GPIO_PORTN_BASE,GPIO_PIN_0,GPIO_PIN_0);
//		GPIOPinWrite(GPIO_PORTN_BASE,GPIO_PIN_1,GPIO_PIN_1);
//		for(loop=0;loop<20000000;loop++){}
//		GPIOPinWrite(GPIO_PORTN_BASE,GPIO_PIN_0,0x0);
//		GPIOPinWrite(GPIO_PORTN_BASE,GPIO_PIN_1,0x0);
//		for(loop=0;loop<20000000;loop++){}


	}
}
