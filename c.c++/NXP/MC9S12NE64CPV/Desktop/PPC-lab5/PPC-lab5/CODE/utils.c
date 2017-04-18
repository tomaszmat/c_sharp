#include "Cpu.h"
#include "sw1.h"
#include "rgbled.h"
#include "utils.h"
#include <stdio.h>
#include <string.h>



#define TERMINAL_BUF_SIZE 100

const char * prompt = "NE64BASE > "; 
char terminal_buffer[TERMINAL_BUF_SIZE];
volatile int terminal_buffer_len;

void init_terminal() {
  terminal_buffer_len = 0;
  terminal_buffer[0] = '\0';
}

void show_prompt(void)
{
  (void)printf("%s", (char*)prompt);
}

void process_terminal_char(char c)
{
	if(c==13)
	{
		(void)putchar(c);
		process_command(terminal_buffer);
		terminal_buffer_len = 0;
		terminal_buffer[0] = '\0';
		show_prompt();
	}
	else
	if(terminal_buffer_len<TERMINAL_BUF_SIZE-1 && c>=32)
	{
		(void)putchar(c);
		terminal_buffer[terminal_buffer_len] = c;
		terminal_buffer_len++;
		terminal_buffer[terminal_buffer_len] = '\0';
	}
	else
	if(terminal_buffer_len>0 && c==8) //backspace
	{
		(void)putchar(c);
		terminal_buffer_len--;
		terminal_buffer[terminal_buffer_len] = '\0';
	} else {
	  (void)putchar('~');
 	  (void)putchar(c); //buffer overrun or unrecognized character code
  	init_terminal();
	}
}


void test_rgb(){
  uint8_t i;
  for(i=0; i<=100; i++) { rgbpwm(i, 0, 0); Cpu_Delay100US(90); }
  for(i=0; i<=100; i++) { rgbpwm(0, i, 0); Cpu_Delay100US(90); }
  for(i=0; i<=100; i++) { rgbpwm(0, 0, i); Cpu_Delay100US(90); }
}

void rgbpwm(byte r, byte g, byte b) {
  new_pwmr = r;
  new_pwmg = g;
  new_pwmb = b;
}

void rgb(byte color) {
  rgbled_PutVal(color);
}

byte dec2hex(byte d)
{
  if(d <= 9) return (byte)(d + '0');
  if(d >= 10 && d <= 15) return (byte)(d - 10 + 'A');
  return (byte)'?';
}

byte hex2dec(char h)
{
  if(h >= '0' && h <= '9') return (byte)(h - '0');
  if(h >= 'A' && h <= 'F') return (byte)(h - 'A' + 10);
  if(h >= 'a' && h <= 'f') return (byte)(h - 'a' + 10);
  return 0;
}
int8_t ishex(char c)
{
  return (c>='0' && c<='9') || (c>='A' && c<='F') || (c>='a' && c<='f');
}
int8_t isdec(char c)
{
  return (c>='0' && c<='9');
}

int8_t isletter(char c)
{
  return ((c>='a' && c<='z') || (c>='A' && c<='Z'));
}

int16_t kju_atoi(char * s)
{
  int result = 0;
  while(isdec(*s))
  {
    result = result * 10 + *s - '0';
    s++;
  }
  return result;
}

int16_t process_arg(char ** s)
{
  int result = 0;
  while(!isdec(**s))(*s)++;
  while(isdec(**s))
  {
    result = result * 10 + **s - '0';
    (*s)++;
  }
  return result;
}

int16_t process_hex_arg(char ** s)
{
  int result = 0;
  while(!ishex(**s))(*s)++;
  while(ishex(**s))
  {
    result = (result <<4) | hex2dec(**s);
    (*s)++;
  }
  return result;
}


#pragma CODE_SEG __NEAR_SEG NON_BANKED

volatile word adc[8];
volatile void (*putch)(char);

__interrupt void adc_isr(void)
{
  adc[0] = ATDDR0;
  adc[1] = ATDDR1;
  adc[2] = ATDDR2;
  adc[3] = ATDDR3;
  adc[4] = ATDDR4;
  adc[5] = ATDDR5;
  adc[6] = ATDDR6;
  adc[7] = ATDDR7;
}
__interrupt void uart0_rx(void) {
  byte s = SCI0SR1;
  byte d = SCI0DRL;
  process_terminal_char(d);
}

#pragma CODE_SEG DEFAULT

void TERMIO_PutChar(char c){
  while(!SCI0SR1_TC);
  SCI0DRL = (byte)c;
}

byte spi(byte d) { 
  while(!SPISR_SPTEF) {}
  SPIDR = d;
  while(!SPISR_SPIF) {}
  return SPIDR;
}


byte wait_sw_pressed(void) {
    if(sw1_GetVal()==0) { //pressing a button grouds signal to zero
        Cpu_Delay100US(100); //wait 10 ms until switch stabilises
        if(sw1_GetVal()!=0) //problem: after 10ms the switch is no longer pressed
            return 0; 
        while(sw1_GetVal()==0){ } //wait until user stops pressing a button
        return 1; 
    }
    return 0; //nothing happened, return 0 (FALSE)
}
