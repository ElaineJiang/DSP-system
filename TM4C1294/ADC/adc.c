/*
 * adc.c
 *
 *  Created on: 2016Äê5ÔÂ26ÈÕ
 *      Author: Yi
 */

#include "adc.h"

#define Sequence1	1
#define Sequence2	2
#define Sequence3	3

uint32_t ui32ADC0_Sequence1[8];		//sequencer zero captures up to eight samples
uint32_t ui32ADC0_Sequence2[4];		//sequencers one and two capture up to four samples
uint32_t ui32ADC0_Sequence3[1];		//sequencer three captures a single sample

uint32 mcu_temp = 0;

void adc_init(void)
{
	//ADC0-Sequence3
	SysCtlPeripheralEnable(SYSCTL_PERIPH_ADC0);
	ADCSequenceConfigure(ADC0_BASE, Sequence3, ADC_TRIGGER_PROCESSOR, 0);
	ADCSequenceStepConfigure(ADC0_BASE, Sequence3, 0, ADC_CTL_TS|ADC_CTL_IE|ADC_CTL_END);
	ADCSequenceEnable(ADC0_BASE, Sequence3);

	//ADC0-Sequence1
	//configure pin pb5
	SysCtlPeripheralEnable(SYSCTL_PERIPH_GPIOB);
	GPIOPinTypeADC(GPIO_PORTB_BASE, GPIO_PIN_5);

	ADCSequenceConfigure(ADC0_BASE, Sequence1, ADC_TRIGGER_PROCESSOR, 0);
	ADCSequenceStepConfigure(ADC0_BASE, Sequence1, 0, ADC_CTL_CH11);		//pin-pb5
	ADCSequenceStepConfigure(ADC0_BASE, Sequence1, 1, ADC_CTL_CH11);
	ADCSequenceStepConfigure(ADC0_BASE, Sequence1, 2, ADC_CTL_CH11);
	ADCSequenceStepConfigure(ADC0_BASE, Sequence1, 3, ADC_CTL_CH11|ADC_CTL_IE|ADC_CTL_END);
	ADCSequenceEnable(ADC0_BASE, Sequence1);
}

uint32 mcu_temp_get(void)
{
	uint32_t ui32TempAvg, ui32TempValueC;
	ADCProcessorTrigger(ADC0_BASE, Sequence3);
	while(!ADCIntStatus(ADC0_BASE, Sequence3, false));
	ADCIntClear(ADC0_BASE, Sequence3);
	ADCSequenceDataGet(ADC0_BASE, Sequence3, ui32ADC0_Sequence3);
	ui32TempAvg = ui32ADC0_Sequence3[0];
	ui32TempValueC = 1475 - ((2475 * ui32TempAvg)) / 4096;
	return ui32TempValueC;
}

void adc_voltage_get(void)
{
	ADCProcessorTrigger(ADC0_BASE, Sequence1);
	while(!ADCIntStatus(ADC0_BASE, Sequence1, false));
	ADCIntClear(ADC0_BASE, Sequence1);
	ADCSequenceDataGet(ADC0_BASE, Sequence1, ui32ADC0_Sequence1);
}

