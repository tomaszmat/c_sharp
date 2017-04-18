#include <stdio.h>
#include <string.h>
#include "commands.h"
#include "utils.h"
#include "rgbled.h"
#include "leds.h"

void cmd_invalid(char *arg);
void cmd_help(char *arg);
void cmd_rgb(char*arg);
void cmd_reset(char *arg);
void cmd_adc(char*arg);

volatile byte adc_send_results;
#pragma MESSAGE DISABLE C5703
void cmd_adc(char*arg){
  adc_send_results = !adc_send_results;
  //(void)printf("%d %d\r\n", adc[0], adc[1]);  
}

const terminal_command commands[] =
{
	{ "help", 0, cmd_help, "[command_name]" },
	{ "adc", 0, cmd_adc, "read ADC" },
	{ "rgb", 1, cmd_rgb, "rgb R G B (0..100%)" },
  { "reset", 0, cmd_reset, "restart the board"},      
	{ NULL, 0, cmd_invalid, "" } //do not remove nor change - this is a handler for unrecognized command
};

void _Startup(void);
#pragma MESSAGE DISABLE C5703
void cmd_reset(char *arg){
  (void)printf("will reboot in 2 seconds...\r\n");
  Cpu_Delay100US(20000U);
  _Startup();
}


#pragma MESSAGE DISABLE C5703
void cmd_rgb(char *arg) {
  int16_t r, g, b;
  r = process_arg(&arg);
  g = process_arg(&arg);
  b = process_arg(&arg);
  if(r<0 || r>100) r = 1;
  if(g<0 || g>100) g = 1;
  if(b<0 || b>100) b = 1;
  rgbpwm((int8_t)r, (int8_t)g, (int8_t)b);
}

#pragma MESSAGE DISABLE C5703
void cmd_invalid(char *arg) {
	(void)puts("Error: command not found.\r\n");
}


void cmd_help(char *arg) {
  byte n;
	for(n=0; n < N_COMMANDS-1; n++)  
  	if(arg == NULL || strcmp(commands[n].name, arg) == 0)
  	  (void)printf("> %s - %s\r\n", commands[n].name, commands[n].desc); 
}

void process_command(char *txt) {
	int n, cmd_len;
	bool found;
	found = 0;
	for(n=0; n < N_COMMANDS-1; n++)
	{
	  cmd_len = strlen(commands[n].name);
		if(strncmp(commands[n].name, txt, cmd_len)==0)
		{
		  if(txt[cmd_len] == '\0') //no arguments
		  {
		    if(commands[n].args_required)
		    {
		      (void)puts("Error: missing command argument(s).\r\n > ");
		      cmd_help(commands[n].name);
		    }
		    else
		      commands[n].function(0L);//command without arguments
		  }
		  else {
		    if(txt[cmd_len] == ' ')
			    commands[n].function(txt + cmd_len + 1);//command with arguments
			  else
			    (void)puts("Error: wrong command name or syntax error.\r\n");
		  }
			found = 1;
		}
	}
	if(!found) cmd_invalid(NULL);
}


