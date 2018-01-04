/*
 * init.c
 *
 *  Created on: 2016Äê6ÔÂ7ÈÕ
 *      Author: Yi
 */

#include "init.h"

extern uint32 g_ui32SysClock = 0;
extern uint32 g_ui32SysClockReal = 0;

void sys_init(void)
{
	g_ui32SysClock = MAP_SysCtlClockFreqSet((SYSCTL_XTAL_25MHZ | SYSCTL_OSC_MAIN | SYSCTL_USE_PLL | SYSCTL_CFG_VCO_480), 120000000);
	SysCtlPeripheralEnable(SYSCTL_PERIPH_GPION);
	SysCtlPeripheralEnable(SYSCTL_PERIPH_GPIOF);//led
	while(!SysCtlPeripheralReady(SYSCTL_PERIPH_GPION)){};
	volatile uint32_t loop;

	g_ui32SysClockReal = SysCtlClockGet();

	GPIOPinTypeGPIOOutput(GPIO_PORTN_BASE, GPIO_PIN_0|GPIO_PIN_1);
	GPIOPinTypeGPIOOutput(GPIO_PORTF_BASE, GPIO_PIN_0|GPIO_PIN_4);

	GPIOPinWrite(GPIO_PORTN_BASE, GPIO_PIN_0|GPIO_PIN_1, 0);
	GPIOPinWrite(GPIO_PORTF_BASE, GPIO_PIN_0|GPIO_PIN_4, 0);

	SysCtlPeripheralEnable(SYSCTL_PERIPH_TIMER0);
    TimerConfigure(TIMER0_BASE,TIMER_CFG_PERIODIC);
    TimerLoadSet(TIMER0_BASE, TIMER_A, (g_ui32SysClock -1) / 1000);

    IntEnable(INT_TIMER0A);
    TimerIntEnable(TIMER0_BASE, TIMER_TIMA_TIMEOUT);
    IntMasterEnable();

    TimerEnable(TIMER0_BASE, TIMER_A);
}
