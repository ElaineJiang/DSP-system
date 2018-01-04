/*
 * isr.h
 *
 *  Created on: 2016Äê5ÔÂ27ÈÕ
 *      Author: Yi
 */

#ifndef ISR_H_
#define ISR_H_

#include "..\common.h"
#include "..\includes.h"

void UARTIntHandler(void);
void Timer0IntHandler(void);

int16_t hp_filter(int16_t sample);
int16_t lp_filter(int16_t sample);
int16_t bp_filter(int16_t sample);
int16_t bs_filter(int16_t sample);
int16_t dc_estimator(register int32_t *p, register int16_t x);

#endif /* ISR_H_ */
