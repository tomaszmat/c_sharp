/* ###################################################################
**     Filename    : main.c
**     Project     : test_101v
**     Processor   : MC9S08QE16CLC
**     Version     : Driver 01.12
**     Compiler    : CodeWarrior HCS08 C Compiler
**     Date/Time   : 2017-05-14, 19:39, # CodeGen: 0
**     Abstract    :
**         Main module.
**         This module contains user's application code.
**     Settings    :
**     Contents    :
**         No public methods
**
** ###################################################################*/
/*!
** @file main.c
** @version 01.12
** @brief
**         Main module.
**         This module contains user's application code.
*/         
/*!
**  @addtogroup main_module main module documentation
**  @{
*/         
/* MODULE main */


/* Including needed modules to compile this module/procedure */
#include "Cpu.h"
#include "Events.h"
#include "led.h"
#include "rf_ce.h"
#include "rf_irq.h"
#include "rf_nss.h"
#include "SPI.h"
#include "RTC.h"
/* Include shared modules, which are used for whole project */
#include "PE_Types.h"
#include "PE_Error.h"
#include "PE_Const.h"
#include "IO_Map.h"

/* User includes (#include below this line is not maintained by Processor Expert) */

#include "rfm7x_tm.h"
#include "rfm7x.h"
#include "ulp.h"


void main(void)
{
  /* Write your local variable definition here */

  /*** Processor Expert internal initialization. DON'T REMOVE THIS CODE!!! ***/
  PE_low_level_init();
  /*** End of Processor Expert internal initialization.                    ***/
 
    
 rfm7x_init(RFM73);

 if(rfm7x_is_present())
 {
	  rfm7x_channel(45);
	  rfm7x_mode_transmit();
	  
	#ifdef TEST
	  led_PutVal(1);
	#endif
  } 
  
 
 for(;;)
  {
	 
	 /*
	 	 	rfm7x_mode_powerdown();
	 		SPIC1 &= ~(1<<SPIC1_SPE);   // zeruj bity spi off
	 		PTBDD |=((1<<PTBDD_PTBDD3)|(1<<PTBDD_PTBDD4)|(1<<PTBDD_PTBDD5)|(1<<PTBDD_PTBDD2)|(1<<PTBDD_PTBDD6)); // spi ports output
	 		PTBD  |=((1<<PTBD_PTBD3)|(1<<PTBD_PTBD4)|(1<<PTBD_PTBD5)|(1<<PTBD_PTBD2)|(1<<PTBD_PTBD6)); // spi ports value 1
	 		PTADD |= (1<<PTADD_PTADD3);
	 		PTAD |=(1<<PTAD_PTAD3);
	 		PTBPE |= ((1<<PTBPE_PTBPE3)|(1<<PTBPE_PTBPE4)|(1<<PTBPE_PTBPE5)|(1<<PTBPE_PTBPE2)|(1<<PTBPE_PTBPE6));//pull up
	 		PTAPE |= (1<<PTAPE_PTAPE3); //pull uap na pta3  
	 	  
	 */
	 Cpu_SetStopMode();
  }

  /*** Don't write any code pass this line, or it will be deleted during code generation. ***/
  /*** RTOS startup code. Macro PEX_RTOS_START is defined by the RTOS component. DON'T MODIFY THIS CODE!!! ***/
  #ifdef PEX_RTOS_START
    PEX_RTOS_START();                  /* Startup of the selected RTOS. Macro is defined by the RTOS component. */
  #endif
  /*** End of RTOS startup code.  ***/
  /*** Processor Expert end of main routine. DON'T MODIFY THIS CODE!!! ***/
  for(;;){}
  /*** Processor Expert end of main routine. DON'T WRITE CODE BELOW!!! ***/
} /*** End of main routine. DO NOT MODIFY THIS TEXT!!! ***/

/* END main */
/*!
** @}
*/
/*
** ###################################################################
**
**     This file was created by Processor Expert 10.3 [05.09]
**     for the Freescale HCS08 series of microcontrollers.
**
** ###################################################################
*/
