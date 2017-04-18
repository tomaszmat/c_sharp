/** ###################################################################
**     Filename  : Events.c
**     Project   : cik1
**     Processor : MC9S12NE64CPV
**     Component : Events
**     Version   : Driver 01.04
**     Compiler  : CodeWarrior HC12 C Compiler
**     Date/Time : 2017-03-06, 09:33
**     Abstract  :
**         This is user's event module.
**         Put your event handler code here.
**     Settings  :
**     Contents  :
**         No public methods
**
** ###################################################################*/
/* MODULE Events */


#include "Cpu.h"
#include "Events.h"

/* User includes (#include below this line is not maintained by Processor Expert) */

#pragma CODE_SEG DEFAULT

/*
** ===================================================================
**     Event       :  TI1_OnInterrupt (module Events)
**
**     Component   :  TI1 [TimerInt]
**     Description :
**         When a timer interrupt occurs this event is called (only
**         when the component is enabled - <Enable> and the events are
**         enabled - <EnableEvent>). This event is enabled only if a
**         <interrupt service/event> is enabled.
**     Parameters  : None
**     Returns     : Nothing
** ===================================================================
*/
uint8_t tickA0;
uint8_t tickA1;
uint8_t tickL; 

/*
extern volatile uint8_t val_r = 20;
extern volatile uint8_t val_g = 40; 
extern volatile uint8_t val_b = 60;
 */
//volatile uint8_t cnt = 0;
     //char t[100000];

extern volatile uint8_t sync_r = 0;
extern volatile uint8_t sync_g = 0;
extern volatile uint8_t sync_b = 0;

uint8_t r;
uint8_t g;
uint8_t b;
uint8_t cnt = 0;

void PWMtimer_OnInterrupt(void)
{

r = sync_r;
g = sync_g;
b = sync_b;


    // tutaj zmienne powstaja tylko raz a nie za kazym razem kiedy jest wywoalana funkcja  
    if(cnt == 0) 
    {
        if(r > 0)  rgb_PutBit(2, TRUE);
        if(g > 0)  rgb_PutBit(1, TRUE);
        if(b > 0)  rgb_PutBit(0, TRUE);
    } 
    else if(cnt < 255) 
    {
         if( cnt == r) rgb_PutBit(2, FALSE);
         if( cnt == g) rgb_PutBit(1, FALSE);
         if( cnt == b) rgb_PutBit(0, FALSE);
    }
     cnt++;
  /* Write your code here ... */
  
  
}
//MISRA - read this!

  /*
if(cnt == 0)
   {
        if((cnt == val_r)&& (val_r >0))       { rgb_PutBit(0, TRUE);} 
        if((cnt ==  val_g) && (val_g >40))    { rgb_PutBit(1, TRUE);} 
        if((cnt == val_b) && (val_b  >60))    { rgb_PutBit(2, TRUE);} 
        cnt++;

   }
   
   if(cnt == 99)
   {
      cnt =0;
      ++cnt;
   }
 
  tickA0++;
  tickA1++;
  tickL++;
  if(tickA0%2 == 0) {  A1_NegVal();  tickA0 = 0;}
  if(tickA1%5 == 0) {  A0_NegVal();  tickA1 = 0;}
  leds_PutVal(tickL);
  if(tickL== 255){ tickL = 0;}   */
/* END Events */

/*
** ###################################################################
**
**     This file was created by Processor Expert 3.02 [04.44]
**     for the Freescale HCS12 series of microcontrollers.
**
** ###################################################################
*/
