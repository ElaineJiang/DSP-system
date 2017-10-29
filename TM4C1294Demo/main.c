#include "includes.h"

uint32 g_ui32SysClock = 0;

int main(void)
{
	g_ui32SysClock = MAP_SysCtlClockFreqSet((SYSCTL_XTAL_25MHZ | SYSCTL_OSC_MAIN | SYSCTL_USE_PLL | SYSCTL_CFG_VCO_480), 120000000);


	while(1)
	{

	}
}
