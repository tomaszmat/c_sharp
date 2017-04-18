#pragma ONCE
#include "PE_Types.h"

void rgb(byte color);
extern volatile int8_t new_pwmr, new_pwmg, new_pwmb;
void rgbpwm(byte r, byte g, byte b);
void test_rgb(void);
byte spi(byte d);
void process_terminal_char(char c);
void process_command(char *txt);
byte wait_sw_pressed(void);
byte dec2hex(byte d);
byte hex2dec(char h);
int8_t ishex(char c);
int8_t isdec(char c);
int8_t isletter(char c);
int16_t kju_atoi(char * s);
int16_t process_hex_arg(char ** s);
int16_t process_arg(char ** s);
void init_terminal(void);
extern volatile byte adc_send_results;
extern volatile word adc[8];
extern volatile uint32_t system_1s_timer;
