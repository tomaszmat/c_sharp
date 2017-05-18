/* ###################################################################
**     Filename    : Events.c
**     Project     : test_101v
**     Processor   : MC9S08QE16CLC
**     Component   : Events
**     Version     : Driver 01.02
**     Compiler    : CodeWarrior HCS08 C Compiler
**     Date/Time   : 2017-05-14, 19:39, # CodeGen: 0
**     Abstract    :
**         This is user's event module.
**         Put your event handler code here.
**     Settings    :
**     Contents    :
**         No public methods
**
** ###################################################################*/
/*!
** @file Events.c
** @version 01.02
** @brief
**         This is user's event module.
**         Put your event handler code here.
*/         
/*!
**  @addtogroup Events_module Events module documentation
**  @{
*/         
/* MODULE Events */


#include "Cpu.h"
#include "Events.h"

/* User includes (#include below this line is not maintained by Processor Expert) */
#include "rfm7x_tm.h"
#include "rfm7x.h"
#include "ulp.h"

ISR(rtc_isr)
{
		_RTC_CLEAN_IR_FLAG;
		_SPI_ON;	
		
		_PTA3_AS_INPUT;	
		
		_PTA3_PULL_UP_OFF;
		_PORTB_PULL_UPS_OFF;
		
		rfm7x_mode_transmit();
		
		rfm7x_transmit_message_once((const unsigned char *)"Hi there!", 9+1); //wysy³anie pakietu danych bez potwierdzenia
			while(rfm7x_transmit_fifo_full()){} //czekaj na wys³anie pakietu
		
			rfm7x_mode_powerdown();
		_SPI_OFF;
		
		_PORTB_AS_OUTPUT;		
		_PORTB_SET_AT_OUTPUTS;
	
		#ifdef TEST
			led_PutVal(1);
			Cpu_Delay100US(10000);
			led_PutVal(0);
		#endif
		
		_RTC_IR_ON;	
}

/* END Events */

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
