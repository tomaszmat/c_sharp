#include <stdio.h>	
#include <math.h>	
#include "turtle.h"	

void trojkat(double bok, int grubosc, COLORREF kolor){ 
	set_angle(0);
	pen(grubosc, kolor);
	line(bok);
	rotate(-120);
	line(bok);
	rotate(-120);
	line(bok);
	no_pen();
}

void main()
{
	if(init(600, 600, white) != OK) 
	{
		printf("Problem z zolwiem.\n"); 
		return;
	}
	diplay_messages(true);

	move_to(300, 300);
	trojkat(100,2,green);

	getchar();
	done();
