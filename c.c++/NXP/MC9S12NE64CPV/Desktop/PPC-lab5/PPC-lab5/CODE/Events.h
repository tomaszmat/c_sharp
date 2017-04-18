/** ###################################################################
**     Filename  : Events.h
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

#ifndef __Events_H
#define __Events_H
/* MODULE Events */

#include "PE_Types.h"
#include "PE_Error.h"
#include "PE_Const.h"
#include "IO_Map.h"
#include "leds.h"
#include "sw1.h"
#include "uart0.h"
#include "rgbled.h"
#include "slow_timer.h"
#include "fast_timer.h"
#include "rf_ce.h"
#include "rf_nss.h"
#include "rf_irq.h"
#include "SPI1.h"
#include "ADC1.h"

#pragma CODE_SEG DEFAULT


void rf_irq_OnInterrupt(void);
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
void slow_timer_OnInterrupt(void);
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

void RTC_OnInterrupt(void);
/*
** ===================================================================
**     Event       :  RTC_OnInterrupt (module Events)
**
**     Component   :  RTC [TimerInt]
**     Description :
**         When a timer interrupt occurs this event is called (only
**         when the component is enabled - <Enable> and the events are
**         enabled - <EnableEvent>). This event is enabled only if a
**         <interrupt service/event> is enabled.
**     Parameters  : None
**     Returns     : Nothing
** ===================================================================
*/

void Ir_OnCapture(void);
/*
** ===================================================================
**     Event       :  Ir_OnCapture (module Events)
**
**     Component   :  Ir [Capture]
**     Description :
**         This event is called on capturing of Timer/Counter actual
**         value (only when the component is enabled - <Enable> and the
**         events are enabled - <EnableEvent>.This event is available
**         only if a <interrupt service/event> is enabled.
**     Parameters  : None
**     Returns     : Nothing
** ===================================================================
*/

void bt_state_OnInterrupt(void);
/*
** ===================================================================
**     Event       :  bt_state_OnInterrupt (module Events)
**
**     Component   :  bt_state [ExtInt]
**     Description :
**         This event is called when an active signal edge/level has
**         occurred.
**     Parameters  : None
**     Returns     : Nothing
** ===================================================================
*/
void Ir_OnOverflow(void);
/*
** ===================================================================
**     Event       :  Ir_OnOverflow (module Events)
**
**     Component   :  Ir [Capture]
**     Description :
**         This event is called if counter overflows (only when the
**         component is enabled - <Enable> and the events are enabled -
**         <EnableEvent>.This event is available only if a <interrupt
**         service/event> is enabled.
**     Parameters  : None
**     Returns     : Nothing
** ===================================================================
*/

void fast_timer_OnInterrupt(void);
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

void Cpu_OnReset(void);
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

/* END Events */
#endif /* __Events_H*/

/*
** ###################################################################
**
**     This file was created by Processor Expert 3.02 [04.44]
**     for the Freescale HCS12 series of microcontrollers.
**
** ###################################################################
*/
