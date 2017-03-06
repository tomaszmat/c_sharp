/** ###################################################################
**     Filename  : cik1.c
**     Project   : cik1
**     Processor : MC9S12NE64CPV
**     Version   : Driver 01.14
**     Compiler  : CodeWarrior HC12 C Compiler
**     Date/Time : 2017-03-06, 09:33
**     Abstract  :
**         Main module.
**         This module contains user's application code.
**     Settings  :
**     Contents  :
**         No public methods
**
** ###################################################################*/
/* MODULE cik1 */

/* Including needed modules to compile this module/procedure */
#include "Cpu.h"
#include "Events.h"
#include "A0.h"
#include "sw1.h"
#include "A1.h"
#include "TI1.h"
/* Include shared modules, which are used for whole project */
#include "PE_Types.h"
#include "PE_Error.h"
#include "PE_Const.h"
#include "IO_Map.h"

/* User includes (#include below this line is not maintained by Processor Expert) */


void main(void)
{
  /* Write your local variable definition here */

/*Defs*/
//For delays
int _on = 1000;
int _off = 1000;
 

  /*** Processor Expert internal initialization. DON'T REMOVE THIS CODE!!! ***/
  PE_low_level_init();
  /*** End of Processor Expert internal initialization.                    ***/

  /* Write your code here */
  
   for(;;)  // Execute code in polling
   {
      
      
      
      // Led on, if switch on
      //A0_PutVal( !(sw1_GetVal() ) ); 
       
      
       // Led toogle
     /* A0_PutVal(1);
      Cpu_Delay100US(_on);
       A0_PutVal(0);
      Cpu_Delay100US(_off);
      */
      

   }  


  /*** Processor Expert end of main routine. DON'T MODIFY THIS CODE!!! ***/
  for(;;){}
  /*** Processor Expert end of main routine. DON'T WRITE CODE BELOW!!! ***/
} /*** End of main routine. DO NOT MODIFY THIS TEXT!!! ***/

/* END cik1 */
/*
** ###################################################################
**
**     This file was created by Processor Expert 3.02 [04.44]
**     for the Freescale HCS12 series of microcontrollers.
**
** ###################################################################
*/
