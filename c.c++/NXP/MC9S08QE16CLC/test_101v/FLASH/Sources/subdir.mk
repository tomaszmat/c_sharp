################################################################################
# Automatically-generated file. Do not edit!
################################################################################

-include ../makefile.local

# Add inputs and outputs from these tool invocations to the build variables 
C_SRCS_QUOTED += \
"../Sources/Events.c" \
"../Sources/main.c" \
"../Sources/rfm7x.c" \
"../Sources/rfm7x_tm.c" \

C_SRCS += \
../Sources/Events.c \
../Sources/main.c \
../Sources/rfm7x.c \
../Sources/rfm7x_tm.c \

OBJS += \
./Sources/Events_c.obj \
./Sources/main_c.obj \
./Sources/rfm7x_c.obj \
./Sources/rfm7x_tm_c.obj \

OBJS_QUOTED += \
"./Sources/Events_c.obj" \
"./Sources/main_c.obj" \
"./Sources/rfm7x_c.obj" \
"./Sources/rfm7x_tm_c.obj" \

C_DEPS += \
./Sources/Events_c.d \
./Sources/main_c.d \
./Sources/rfm7x_c.d \
./Sources/rfm7x_tm_c.d \

C_DEPS_QUOTED += \
"./Sources/Events_c.d" \
"./Sources/main_c.d" \
"./Sources/rfm7x_c.d" \
"./Sources/rfm7x_tm_c.d" \

OBJS_OS_FORMAT += \
./Sources/Events_c.obj \
./Sources/main_c.obj \
./Sources/rfm7x_c.obj \
./Sources/rfm7x_tm_c.obj \


# Each subdirectory must supply rules for building sources it contributes
Sources/Events_c.obj: ../Sources/Events.c
	@echo 'Building file: $<'
	@echo 'Executing target #1 $<'
	@echo 'Invoking: HCS08 Compiler'
	"$(HC08ToolsEnv)/chc08" -ArgFile"Sources/Events.args" -ObjN="Sources/Events_c.obj" "$<" -Lm="$(@:%.obj=%.d)" -LmCfg=xilmou
	@echo 'Finished building: $<'
	@echo ' '

Sources/%.d: ../Sources/%.c
	@echo 'Regenerating dependency file: $@'
	
	@echo ' '

Sources/main_c.obj: ../Sources/main.c
	@echo 'Building file: $<'
	@echo 'Executing target #2 $<'
	@echo 'Invoking: HCS08 Compiler'
	"$(HC08ToolsEnv)/chc08" -ArgFile"Sources/main.args" -ObjN="Sources/main_c.obj" "$<" -Lm="$(@:%.obj=%.d)" -LmCfg=xilmou
	@echo 'Finished building: $<'
	@echo ' '

Sources/rfm7x_c.obj: ../Sources/rfm7x.c
	@echo 'Building file: $<'
	@echo 'Executing target #3 $<'
	@echo 'Invoking: HCS08 Compiler'
	"$(HC08ToolsEnv)/chc08" -ArgFile"Sources/rfm7x.args" -ObjN="Sources/rfm7x_c.obj" "$<" -Lm="$(@:%.obj=%.d)" -LmCfg=xilmou
	@echo 'Finished building: $<'
	@echo ' '

Sources/rfm7x_tm_c.obj: ../Sources/rfm7x_tm.c
	@echo 'Building file: $<'
	@echo 'Executing target #4 $<'
	@echo 'Invoking: HCS08 Compiler'
	"$(HC08ToolsEnv)/chc08" -ArgFile"Sources/rfm7x_tm.args" -ObjN="Sources/rfm7x_tm_c.obj" "$<" -Lm="$(@:%.obj=%.d)" -LmCfg=xilmou
	@echo 'Finished building: $<'
	@echo ' '


