################################################################################
# Automatically-generated file. Do not edit!
################################################################################

SHELL = cmd.exe

CG_TOOL_ROOT := C:/ti/ccsv6/tools/compiler/ti-cgt-arm_5.2.2

ORDERED_OBJS += \
"./main.obj" \
"./tm4c1294ncpdt_startup_ccs.obj" \
"./driverlib/adc.obj" \
"./driverlib/aes.obj" \
"./driverlib/can.obj" \
"./driverlib/comp.obj" \
"./driverlib/cpu.obj" \
"./driverlib/crc.obj" \
"./driverlib/des.obj" \
"./driverlib/eeprom.obj" \
"./driverlib/emac.obj" \
"./driverlib/epi.obj" \
"./driverlib/flash.obj" \
"./driverlib/fpu.obj" \
"./driverlib/gpio.obj" \
"./driverlib/hibernate.obj" \
"./driverlib/i2c.obj" \
"./driverlib/interrupt.obj" \
"./driverlib/lcd.obj" \
"./driverlib/mpu.obj" \
"./driverlib/onewire.obj" \
"./driverlib/pwm.obj" \
"./driverlib/qei.obj" \
"./driverlib/shamd5.obj" \
"./driverlib/ssi.obj" \
"./driverlib/sw_crc.obj" \
"./driverlib/sysctl.obj" \
"./driverlib/sysexc.obj" \
"./driverlib/systick.obj" \
"./driverlib/timer.obj" \
"./driverlib/uart.obj" \
"./driverlib/udma.obj" \
"./driverlib/usb.obj" \
"./driverlib/watchdog.obj" \
"./UART/uart.obj" \
"./ISR/isr.obj" \
"./INIT/init.obj" \
"./ADC/adc.obj" \
"../tm4c1294ncpdt.cmd" \
"../driverlib/rvmdk/driverlib.lib" \
$(GEN_CMDS__FLAG) \
-l"libc.a" \

-include ../makefile.init

RM := DEL /F
RMDIR := RMDIR /S/Q

# All of the sources participating in the build are defined here
-include sources.mk
-include subdir_vars.mk
-include driverlib/subdir_vars.mk
-include driverlib/rvmdk/subdir_vars.mk
-include UART/subdir_vars.mk
-include ISR/subdir_vars.mk
-include INIT/subdir_vars.mk
-include ADC/subdir_vars.mk
-include subdir_rules.mk
-include driverlib/subdir_rules.mk
-include driverlib/rvmdk/subdir_rules.mk
-include UART/subdir_rules.mk
-include ISR/subdir_rules.mk
-include INIT/subdir_rules.mk
-include ADC/subdir_rules.mk
-include objects.mk

ifneq ($(MAKECMDGOALS),clean)
ifneq ($(strip $(S_DEPS)),)
-include $(S_DEPS)
endif
ifneq ($(strip $(S_UPPER_DEPS)),)
-include $(S_UPPER_DEPS)
endif
ifneq ($(strip $(S62_DEPS)),)
-include $(S62_DEPS)
endif
ifneq ($(strip $(C64_DEPS)),)
-include $(C64_DEPS)
endif
ifneq ($(strip $(ASM_DEPS)),)
-include $(ASM_DEPS)
endif
ifneq ($(strip $(CC_DEPS)),)
-include $(CC_DEPS)
endif
ifneq ($(strip $(S55_DEPS)),)
-include $(S55_DEPS)
endif
ifneq ($(strip $(C67_DEPS)),)
-include $(C67_DEPS)
endif
ifneq ($(strip $(CLA_DEPS)),)
-include $(CLA_DEPS)
endif
ifneq ($(strip $(C??_DEPS)),)
-include $(C??_DEPS)
endif
ifneq ($(strip $(CPP_DEPS)),)
-include $(CPP_DEPS)
endif
ifneq ($(strip $(S??_DEPS)),)
-include $(S??_DEPS)
endif
ifneq ($(strip $(C_DEPS)),)
-include $(C_DEPS)
endif
ifneq ($(strip $(C62_DEPS)),)
-include $(C62_DEPS)
endif
ifneq ($(strip $(CXX_DEPS)),)
-include $(CXX_DEPS)
endif
ifneq ($(strip $(C++_DEPS)),)
-include $(C++_DEPS)
endif
ifneq ($(strip $(ASM_UPPER_DEPS)),)
-include $(ASM_UPPER_DEPS)
endif
ifneq ($(strip $(K_DEPS)),)
-include $(K_DEPS)
endif
ifneq ($(strip $(C43_DEPS)),)
-include $(C43_DEPS)
endif
ifneq ($(strip $(INO_DEPS)),)
-include $(INO_DEPS)
endif
ifneq ($(strip $(S67_DEPS)),)
-include $(S67_DEPS)
endif
ifneq ($(strip $(SA_DEPS)),)
-include $(SA_DEPS)
endif
ifneq ($(strip $(S43_DEPS)),)
-include $(S43_DEPS)
endif
ifneq ($(strip $(OPT_DEPS)),)
-include $(OPT_DEPS)
endif
ifneq ($(strip $(PDE_DEPS)),)
-include $(PDE_DEPS)
endif
ifneq ($(strip $(S64_DEPS)),)
-include $(S64_DEPS)
endif
ifneq ($(strip $(C_UPPER_DEPS)),)
-include $(C_UPPER_DEPS)
endif
ifneq ($(strip $(C55_DEPS)),)
-include $(C55_DEPS)
endif
endif

-include ../makefile.defs

# Add inputs and outputs from these tool invocations to the build variables 
EXE_OUTPUTS += \
TM4C1294Demo.out \

EXE_OUTPUTS__QUOTED += \
"TM4C1294Demo.out" \

BIN_OUTPUTS += \
TM4C1294Demo.hex \

BIN_OUTPUTS__QUOTED += \
"TM4C1294Demo.hex" \


# All Target
all: TM4C1294Demo.out

# Tool invocations
TM4C1294Demo.out: $(OBJS) $(CMD_SRCS) $(LIB_SRCS) $(GEN_CMDS)
	@echo 'Building target: $@'
	@echo 'Invoking: ARM Linker'
	"C:/ti/ccsv6/tools/compiler/ti-cgt-arm_5.2.2/bin/armcl" -mv7M4 --code_state=16 --float_support=FPv4SPD16 --abi=eabi -me -g --gcc --define=ccs="ccs" --define=TARGET_IS_TM4C129_RA0 --define=PART_TM4C1294NCPDT --display_error_number --diag_warning=225 --diag_wrap=off -z -m"TM4C1294Demo.map" --heap_size=0 --stack_size=512 -i"C:/ti/ccsv6/tools/compiler/ti-cgt-arm_5.2.2/lib" -i"C:/ti/ccsv6/tools/compiler/ti-cgt-arm_5.2.2/include" --reread_libs --warn_sections --display_error_number --diag_wrap=off --xml_link_info="TM4C1294Demo_linkInfo.xml" --rom_model -o "TM4C1294Demo.out" $(ORDERED_OBJS)
	@echo 'Finished building target: $@'
	@echo ' '

TM4C1294Demo.hex: $(EXE_OUTPUTS)
	@echo 'Invoking: ARM Hex Utility'
	"C:/ti/ccsv6/tools/compiler/ti-cgt-arm_5.2.2/bin/armhex"  -o "TM4C1294Demo.hex" $(EXE_OUTPUTS__QUOTED)
	@echo 'Finished building: $@'
	@echo ' '

# Other Targets
clean:
	-$(RM) $(EXE_OUTPUTS__QUOTED)$(BIN_OUTPUTS__QUOTED)
	-$(RM) "main.pp" "tm4c1294ncpdt_startup_ccs.pp" "driverlib\adc.pp" "driverlib\aes.pp" "driverlib\can.pp" "driverlib\comp.pp" "driverlib\cpu.pp" "driverlib\crc.pp" "driverlib\des.pp" "driverlib\eeprom.pp" "driverlib\emac.pp" "driverlib\epi.pp" "driverlib\flash.pp" "driverlib\fpu.pp" "driverlib\gpio.pp" "driverlib\hibernate.pp" "driverlib\i2c.pp" "driverlib\interrupt.pp" "driverlib\lcd.pp" "driverlib\mpu.pp" "driverlib\onewire.pp" "driverlib\pwm.pp" "driverlib\qei.pp" "driverlib\shamd5.pp" "driverlib\ssi.pp" "driverlib\sw_crc.pp" "driverlib\sysctl.pp" "driverlib\sysexc.pp" "driverlib\systick.pp" "driverlib\timer.pp" "driverlib\uart.pp" "driverlib\udma.pp" "driverlib\usb.pp" "driverlib\watchdog.pp" "UART\uart.pp" "ISR\isr.pp" "INIT\init.pp" "ADC\adc.pp" 
	-$(RM) "main.obj" "tm4c1294ncpdt_startup_ccs.obj" "driverlib\adc.obj" "driverlib\aes.obj" "driverlib\can.obj" "driverlib\comp.obj" "driverlib\cpu.obj" "driverlib\crc.obj" "driverlib\des.obj" "driverlib\eeprom.obj" "driverlib\emac.obj" "driverlib\epi.obj" "driverlib\flash.obj" "driverlib\fpu.obj" "driverlib\gpio.obj" "driverlib\hibernate.obj" "driverlib\i2c.obj" "driverlib\interrupt.obj" "driverlib\lcd.obj" "driverlib\mpu.obj" "driverlib\onewire.obj" "driverlib\pwm.obj" "driverlib\qei.obj" "driverlib\shamd5.obj" "driverlib\ssi.obj" "driverlib\sw_crc.obj" "driverlib\sysctl.obj" "driverlib\sysexc.obj" "driverlib\systick.obj" "driverlib\timer.obj" "driverlib\uart.obj" "driverlib\udma.obj" "driverlib\usb.obj" "driverlib\watchdog.obj" "UART\uart.obj" "ISR\isr.obj" "INIT\init.obj" "ADC\adc.obj" 
	-@echo 'Finished clean'
	-@echo ' '

.PHONY: all clean dependents
.SECONDARY:

-include ../makefile.targets

