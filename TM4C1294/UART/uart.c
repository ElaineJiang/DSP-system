/*
 * uart.c
 *
 *  Created on: 2016Äê5ÔÂ14ÈÕ
 *      Author: Yi
 */

#include "uart.h"

extern uint32 g_ui32SysClock;

void uart_init(void)
{
    SysCtlPeripheralEnable(SYSCTL_PERIPH_UART0);
    SysCtlPeripheralEnable(SYSCTL_PERIPH_GPIOA);

    GPIOPinConfigure(GPIO_PA0_U0RX);
    GPIOPinConfigure(GPIO_PA1_U0TX);
    GPIOPinTypeUART(GPIO_PORTA_BASE, GPIO_PIN_0 | GPIO_PIN_1);

    SysCtlPeripheralEnable(SYSCTL_PERIPH_GPIOF); //enable GPIO port for LED
    GPIOPinTypeGPIOOutput(GPIO_PORTF_BASE, GPIO_PIN_2); //enable pin for LED PF2


    UARTConfigSetExpClk(UART0_BASE, g_ui32SysClock, 115200,
            (UART_CONFIG_WLEN_8 | UART_CONFIG_STOP_ONE | UART_CONFIG_PAR_NONE));

    IntMasterEnable(); //enable processor interrupts
    IntEnable(INT_UART0); //enable the UART interrupt
    UARTIntEnable(UART0_BASE, UART_INT_RX | UART_INT_RT); //only enable RX and TX interrupts

}


void sci_msg(char * msg)
{
    int i;
    i = 0;
    while(msg[i] != '\0')
    {
        UARTCharPut(UART0_BASE, msg[i]);
        i++;
    }
}
