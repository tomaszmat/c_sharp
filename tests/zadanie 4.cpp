#include "stdafx.h"
#include <stdio.h>

int main(){
	int c=100; 
	printf("Znak \\n to znak\nnowej linii,\n"); 
	printf("a znak \\t to znak\ttabulacji.\n\n");
	
	printf("Wyswietlanie zmiennej typu int z uzyciem:\n");
	printf("- %%d: %d\n", c); 
	printf("- %%i: %i\n", c); 
	printf("- %%x: %x\n", c); 
	printf("- %%o: %o\n", c); 

	getchar();
	return 0;
}