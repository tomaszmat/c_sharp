#include "stdafx.h"
#include <stdio.h>
#include <cmath> 

int main(){
	double a,b,c,x1,x2,delta; 

	a=2; 
	b=-3;
	c=-2;

	delta = b*b -4*a*c;

	x1=(-b -sqrt(delta))/(2*a);
	x2=(-b +sqrt(delta))/(2*a);

	printf("Rozwiazania rownania kwadratowego 2x^2 - 3x - 2 = 0\n\n");

	printf("(wersja z \%%g)\n"); 
	printf("x1=%g\n", x1);       
	printf("x2=%g\n\n", x2);

	printf("(wersja z \%%f)\n");
	printf("x1=%f\n", x1);       
	printf("x2=%f\n\n", x2);

	printf("(wersja z \%%.2f)\n");
	printf("x1=%.2f\n", x1);     
	printf("x2=%.2f\n", x2);

	
	getchar();
	return 0;
}