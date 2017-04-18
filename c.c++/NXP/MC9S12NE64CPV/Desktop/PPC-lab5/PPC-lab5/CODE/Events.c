/** ###################################################################
**     Filename  : Events.c
**     Project   : Project_2
**     Processor : MC9S12NE64CPV
**     Component : Events
**     Version   : Driver 01.04
**     Compiler  : CodeWarrior HC12 C Compiler
**     Date/Time : 2013-02-01, 14:45
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

#define RGB_R 2
#define RGB_G 1
#define RGB_B 4

/*
** ===================================================================
**     Event       :  rf_irq_OnInterrupt (module Events)
**
**     Component   :  rf_irq [ExtInt]
**     Description :
**         This event is called when an active signal edge/level has
**         occurred.
**     Parameters  : None
**     Returns     : Nothing
** ===================================================================
*/
void rfm7x_clear_irq(void); 
void rf_irq_OnInterrupt(void)
{
  rfm7x_clear_irq();  
}


/*
** ===================================================================
**     Event       :  slow_timer_OnInterrupt (module Events)
**
**     Component   :  slow_timer [TimerInt]
**     Description :
**         When a timer interrupt occurs this event is called (only
**         when the component is enabled - <Enable> and the events are
**         enabled - <EnableEvent>). This event is enabled only if a
**         <interrupt service/event> is enabled.
**     Parameters  : None
**     Returns     : Nothing
** ===================================================================
*/
byte cnt;

void slow_timer_OnInterrupt(void)
{
}


/*
** ===================================================================
**     Event       :  fast_timer_OnInterrupt (module Events)
**
**     Component   :  fast_timer [TimerInt]
**     Description :
**         When a timer interrupt occurs this event is called (only
**         when the component is enabled - <Enable> and the events are
**         enabled - <EnableEvent>). This event is enabled only if a
**         <interrupt service/event> is enabled.
**     Parameters  : None
**     Returns     : Nothing
** ===================================================================
*/
volatile int8_t new_pwmr, new_pwmg, new_pwmb;
static int8_t pwmr, pwmg, pwmb;
static uint8_t pwm_counter;
static uint8_t rgb_color_vector;
volatile byte use_bigled = 0;


void fast_timer_OnInterrupt(void)
{
  if(pwm_counter == 0) {
    pwmr = new_pwmr;
    pwmg = new_pwmg;
    pwmb = new_pwmb;
    rgb_color_vector = 0;
    if(pwmr > 0) rgb_color_vector |= RGB_R;
    if(pwmg > 0) rgb_color_vector |= RGB_G;
    if(pwmb > 0) rgb_color_vector |= RGB_B;
  } else {
    if(pwm_counter == pwmr) rgb_color_vector &= ~RGB_R;
    if(pwm_counter == pwmg) rgb_color_vector &= ~RGB_G;
    if(pwm_counter == pwmb) rgb_color_vector &= ~RGB_B;
  }
  if(pwm_counter < 99) pwm_counter++; else pwm_counter = 0;
  rgbled_PutVal(rgb_color_vector);  
}

/*
** ===================================================================
**     Event       :  Cpu_OnReset (module Events)
**
**     Component   :  Cpu [MC9S12NE64_112]
**     Description :
**         This software event is called after reset.
**     Parameters  : None
**     Returns     : Nothing
** ===================================================================
*/
void Cpu_OnReset(void)
{
  /* Write your code here ... */
}

/* END Events */

/*
** ###################################################################
**
**     This file was created by Processor Expert 3.02 [04.44]
**     for the Freescale HCS12 series of microcontrollers.
**
** ###################################################################
*/
