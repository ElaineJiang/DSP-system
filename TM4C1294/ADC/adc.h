/*
 * adc.h
 *
 *  Created on: 2016Äê5ÔÂ26ÈÕ
 *      Author: Yi
 */

#ifndef ADC_ADC_H_
#define ADC_ADC_H_

#include "..\common.h"

extern uint32 mcu_temp;
extern uint32_t ui32ADC0_Sequence1[8];
extern uint32_t ui32ADC0_Sequence2[4];
extern uint32_t ui32ADC0_Sequence3[1];

void adc_init(void);
uint32 mcu_temp_get(void);
void adc_voltage_get(void);



#endif /* ADC_ADC_H_ */
