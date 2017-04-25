################################################################################
# Automatically-generated file. Do not edit!
################################################################################

-include ../makefile.local

# Add inputs and outputs from these tool invocations to the build variables 
C_SRCS_QUOTED += \
"../Generated_Code/Cpu.c" \
"../Generated_Code/IO_Map.c" \
"../Generated_Code/SPI.c" \
"../Generated_Code/Vectors.c" \
"../Generated_Code/led.c" \
"../Generated_Code/rf_ce.c" \
"../Generated_Code/rf_irq.c" \
"../Generated_Code/rf_nss.c" \

C_SRCS += \
../Generated_Code/Cpu.c \
../Generated_Code/IO_Map.c \
../Generated_Code/SPI.c \
../Generated_Code/Vectors.c \
../Generated_Code/led.c \
../Generated_Code/rf_ce.c \
../Generated_Code/rf_irq.c \
../Generated_Code/rf_nss.c \

OBJS += \
./Generated_Code/Cpu_c.obj \
./Generated_Code/IO_Map_c.obj \
./Generated_Code/SPI_c.obj \
./Generated_Code/Vectors_c.obj \
./Generated_Code/led_c.obj \
./Generated_Code/rf_ce_c.obj \
./Generated_Code/rf_irq_c.obj \
./Generated_Code/rf_nss_c.obj \

OBJS_QUOTED += \
"./Generated_Code/Cpu_c.obj" \
"./Generated_Code/IO_Map_c.obj" \
"./Generated_Code/SPI_c.obj" \
"./Generated_Code/Vectors_c.obj" \
"./Generated_Code/led_c.obj" \
"./Generated_Code/rf_ce_c.obj" \
"./Generated_Code/rf_irq_c.obj" \
"./Generated_Code/rf_nss_c.obj" \

C_DEPS += \
./Generated_Code/Cpu_c.d \
./Generated_Code/IO_Map_c.d \
./Generated_Code/SPI_c.d \
./Generated_Code/Vectors_c.d \
./Generated_Code/led_c.d \
./Generated_Code/rf_ce_c.d \
./Generated_Code/rf_irq_c.d \
./Generated_Code/rf_nss_c.d \

C_DEPS_QUOTED += \
"./Generated_Code/Cpu_c.d" \
"./Generated_Code/IO_Map_c.d" \
"./Generated_Code/SPI_c.d" \
"./Generated_Code/Vectors_c.d" \
"./Generated_Code/led_c.d" \
"./Generated_Code/rf_ce_c.d" \
"./Generated_Code/rf_irq_c.d" \
"./Generated_Code/rf_nss_c.d" \

OBJS_OS_FORMAT += \
./Generated_Code/Cpu_c.obj \
./Generated_Code/IO_Map_c.obj \
./Generated_Code/SPI_c.obj \
./Generated_Code/Vectors_c.obj \
./Generated_Code/led_c.obj \
./Generated_Code/rf_ce_c.obj \
./Generated_Code/rf_irq_c.obj \
./Generated_Code/rf_nss_c.obj \


# Each subdirectory must supply rules for building sources it contributes
Generated_Code/Cpu_c.obj: ../Generated_Code/Cpu.c
	@echo 'Building file: $<'
	@echo 'Executing target #5 $<'
	@echo 'Invoking: HCS08 Compiler'
	"$(HC08ToolsEnv)/chc08" -ArgFile"Generated_Code/Cpu.args" -ObjN="Generated_Code/Cpu_c.obj" "$<" -Lm="$(@:%.obj=%.d)" -LmCfg=xilmou
	@echo 'Finished building: $<'
	@echo ' '

Generated_Code/%.d: ../Generated_Code/%.c
	@echo 'Regenerating dependency file: $@'
	
	@echo ' '

Generated_Code/IO_Map_c.obj: ../Generated_Code/IO_Map.c
	@echo 'Building file: $<'
	@echo 'Executing target #6 $<'
	@echo 'Invoking: HCS08 Compiler'
	"$(HC08ToolsEnv)/chc08" -ArgFile"Generated_Code/IO_Map.args" -ObjN="Generated_Code/IO_Map_c.obj" "$<" -Lm="$(@:%.obj=%.d)" -LmCfg=xilmou
	@echo 'Finished building: $<'
	@echo ' '

Generated_Code/SPI_c.obj: ../Generated_Code/SPI.c
	@echo 'Building file: $<'
	@echo 'Executing target #7 $<'
	@echo 'Invoking: HCS08 Compiler'
	"$(HC08ToolsEnv)/chc08" -ArgFile"Generated_Code/SPI.args" -ObjN="Generated_Code/SPI_c.obj" "$<" -Lm="$(@:%.obj=%.d)" -LmCfg=xilmou
	@echo 'Finished building: $<'
	@echo ' '

Generated_Code/Vectors_c.obj: ../Generated_Code/Vectors.c
	@echo 'Building file: $<'
	@echo 'Executing target #8 $<'
	@echo 'Invoking: HCS08 Compiler'
	"$(HC08ToolsEnv)/chc08" -ArgFile"Generated_Code/Vectors.args" -ObjN="Generated_Code/Vectors_c.obj" "$<" -Lm="$(@:%.obj=%.d)" -LmCfg=xilmou
	@echo 'Finished building: $<'
	@echo ' '

Generated_Code/led_c.obj: ../Generated_Code/led.c
	@echo 'Building file: $<'
	@echo 'Executing target #9 $<'
	@echo 'Invoking: HCS08 Compiler'
	"$(HC08ToolsEnv)/chc08" -ArgFile"Generated_Code/led.args" -ObjN="Generated_Code/led_c.obj" "$<" -Lm="$(@:%.obj=%.d)" -LmCfg=xilmou
	@echo 'Finished building: $<'
	@echo ' '

Generated_Code/rf_ce_c.obj: ../Generated_Code/rf_ce.c
	@echo 'Building file: $<'
	@echo 'Executing target #10 $<'
	@echo 'Invoking: HCS08 Compiler'
	"$(HC08ToolsEnv)/chc08" -ArgFile"Generated_Code/rf_ce.args" -ObjN="Generated_Code/rf_ce_c.obj" "$<" -Lm="$(@:%.obj=%.d)" -LmCfg=xilmou
	@echo 'Finished building: $<'
	@echo ' '

Generated_Code/rf_irq_c.obj: ../Generated_Code/rf_irq.c
	@echo 'Building file: $<'
	@echo 'Executing target #11 $<'
	@echo 'Invoking: HCS08 Compiler'
	"$(HC08ToolsEnv)/chc08" -ArgFile"Generated_Code/rf_irq.args" -ObjN="Generated_Code/rf_irq_c.obj" "$<" -Lm="$(@:%.obj=%.d)" -LmCfg=xilmou
	@echo 'Finished building: $<'
	@echo ' '

Generated_Code/rf_nss_c.obj: ../Generated_Code/rf_nss.c
	@echo 'Building file: $<'
	@echo 'Executing target #12 $<'
	@echo 'Invoking: HCS08 Compiler'
	"$(HC08ToolsEnv)/chc08" -ArgFile"Generated_Code/rf_nss.args" -ObjN="Generated_Code/rf_nss_c.obj" "$<" -Lm="$(@:%.obj=%.d)" -LmCfg=xilmou
	@echo 'Finished building: $<'
	@echo ' '


