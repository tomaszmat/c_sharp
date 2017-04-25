/* ###################################################################
**     Filename    : main.c
**     Project     : test2qe4
**     Processor   : MC9S08QE4CTG
**     Version     : Driver 01.12
**     Compiler    : CodeWarrior HCS08 C Compiler
**     Date/Time   : 2017-04-03, 16:47, # CodeGen: 0
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
#include "SPI.h"
#include "rf_nss.h"
#include "rf_ce.h"
#include "rf_irq.h"
/* Include shared modules, which are used for whole project */
#include "PE_Types.h"
#include "PE_Error.h"
#include "PE_Const.h"
#include "IO_Map.h"

/* User includes (#include below this line is not maintained by Processor Expert) */
#include "rfm7x.h"

void RFM7x_CE(byte v)  
{
	rf_ce_PutVal(v);
}
void RFM7x_CSN(byte v)
{
	rf_nss_PutVal(v);
}
void RFM7x_WAIT_MS (word ms)
{
  Cpu_Delay100US(10 * ms);
}
unsigned char rfm7x_SPI_RW(byte value)
{

	unsigned char c = 0;

  while(!SPIS_SPTEF);//wait , dont use ';' , better {} to info comp that is intional waitstate
 SPID = value;
  while(!SPIS_SPRF);
  return SPID;
  }
  /*		REGISTER SPIS
   * SPI Read Buffer Full Flag — SPRF is set at the completion of an SPI transfer to indicate that received data may
be read from the SPI data register (SPID). SPRF is cleared by reading SPRF while it is set, then reading the SPI
data register.
0 No data available in the receive data buffer
1 Data available in the receive data buffer

SPI Transmit Buffer Empty Flag — This bit is set when there is room in the transmit data buffer. It is cleared by
reading SPIS with SPTEF set, followed by writing a data value to the transmit buffer at SPID. SPIS must be read
with SPTEF = 1 before writing data to SPID or the SPID write will be ignored. SPTEF generates an SPTEF CPU
interrupt request if the SPTIE bit in the SPIC1 is also set. SPTEF is automatically set when a data byte transfers
from the transmit buffer into the transmit shift register. For an idle SPI (no data in the transmit buffer or the shift
register and no transfer in progress), data written to SPID is transferred to the shifter almost immediately so
SPTEF is set within two bus cycles allowing a second 8-bit data value to be queued into the transmit buffer. After
completion of the transfer of the value in the shift register, the queued value from the transmit buffer will
automatically move to the shifter and SPTEF will be set to indicate there is room for new data in the transmit
buffer. If no new data is waiting in the transmit buffer, SPTEF simply remains set and no data moves from the
buffer to the shifter.
0 SPI transmit buffer not empty
1 SPI transmit buffer empty
   */




void main(void)
{
  /* Write your local variable definition here */

  /*** Processor Expert internal initialization. DON'T REMOVE THIS CODE!!! ***/
  PE_low_level_init();
  /*** End of Processor Expert internal initialization.                    ***/

  
  /* ### Init_SPI "SPI" init code ... */
  SPI_Init();
  
  
  // Init radio 
  rfm7x_init(RFM73);

  if(rfm7x_is_present())
  {
	  rfm7x_channel(45);
	  rfm7x_mode_transmit();
	  led_PutVal(1);
	  Cpu_Delay100US(10000);
	  led_PutVal(0);
  } 
  else 
  {
	  
	  led_PutVal(1);
	  Cpu_Delay100US(1000);
	  led_PutVal(0);
	  Cpu_Delay100US(1000);	  
	  led_PutVal(1);
	  Cpu_Delay100US(1000);
	  led_PutVal(0);
  }
  
  //SPIC1_SPE=0;
  
  Cpu_SetStopMode();
  
  /* Write your code here */
  /* For example: for(;;) { } */
  
 
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
