#pragma ONCE
#include "Cpu.h"

#define N_COMMANDS (sizeof(commands)/sizeof(commands[0]))

typedef struct terminal_command //a structure binding command name with a function pointer
{
	char* name;
	byte args_required;
	void (*function)(char *);
	char* desc;
} terminal_command;

void process_command(char *txt);
