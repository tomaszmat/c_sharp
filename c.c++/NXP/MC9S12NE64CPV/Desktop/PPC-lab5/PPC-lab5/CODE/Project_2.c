/** ###################################################################
**     Filename  : Project_2.c
**     Project   : Project_2
**     Processor : MC9S12NE64CPV
**     Version   : Driver 01.14
**     Compiler  : CodeWarrior HC12 C Compiler
**     Date/Time : 2013-02-01, 14:45
**     Abstract  :
**         Main module.
**         This module contains user's application code.
**     Settings  :
**     Contents  :
**         No public methods
**
** ###################################################################*/
/* MODULE Project_2 */

/* Including needed modules to compile this module/procedure */
#include "Cpu.h"
#include "Events.h"
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
/* Include shared modules, which are used for whole project */
#include "PE_Types.h"
#include "PE_Error.h"
#include "PE_Const.h"
#include "IO_Map.h"

/* User includes (#include below this line is not maintained by Processor Expert) */
#include "utils.h"
#include <stdio.h>
#include <string.h>

#include "rfm7x.h"


uint16_t main_loop_counter = 0;
void RFM7x_CE(byte v) {rf_ce_PutVal(v);}
void RFM7x_CSN(byte v) { rf_nss_PutVal(v);}
void RFM7x_WAIT_MS (word ms)
{
  Cpu_Delay100US(10 * ms);
}

unsigned char rfm7x_SPI_RW(byte value)
{
  while(!SPISR_SPTEF){} //wait , dont use ';' , better {} to info comp that is intional waitstate
  SPIDR = value;
  while(!SPISR_SPIF){}
  return SPIDR;
}

/*Defs for reciving */
uint8_t rfmsg_len; //Length of recived packet
uint8_t rfpipe; // Pipie number
uint8_t rfmsg[31+1]; //message, max 32 + char end of line (in C)

#define reciving
// #define sending

void main(void)
{
  /* Write your local variable definition here */

  /*** Processor Expert internal initialization. DON'T REMOVE THIS CODE!!! ***/
  PE_low_level_init();
  /*** End of Processor Expert internal initialization.                    ***/

  /* Write your code here */
  init_terminal();
  (void)printf("Initializing NE64BASE...\r\n");


  rfm7x_init(RFM73);
  /*Check rfm7x */
  if(rfm7x_is_present())  { (void)printf("Radio OK...\r\n");}
                     else { (void)printf("Radio NOK...\r\n");}
//  rfm7x_mode_transmit(); // Transmit mode
//
rfm7x_channel(45);

#ifdef reciving
rfm7x_mode_recive();
#endif

#ifdef sending
rfm7x_mode_transmit();
#endif



  for(;;)
  {  
    #ifdef reciving
      if(!rfm7x_receive_fifo_empty())
      { //odebrano jakieś dane
          if(0 != rfm7x_receive(&rfpipe, rfmsg, &rfmsg_len) && rfmsg_len > 0)
            { //danych jest więcej niż 1 bajt
              rfmsg[rfmsg_len] = '\0'; //dodaj znak końca napisu w C do bufora
              (void)printf("rfmsg: %s\r\n", rfmsg); //wyświetl odebrany komunikat w terminalu
            }
      }
    #endif

    #ifdef sending
    rfm7x_transmit_message_once((const unsigned char *)"Hi there!", 9+1); //wysyłanie pakietu danych bez potwierdzenia
    while(rfm7x_transmit_fifo_full()){} //czekaj na wysłanie pakietu
    CpuDelay100US(10000); //pauza
    #endif


    /*
        if(sw1_GetVal() == 0) {
          adc_send_results = !adc_send_results; //toggle
          while(sw1_GetVal() == 0);
        }

        if((main_loop_counter & 0x7f) == 0x33 && adc_send_results) {
            (void)printf("adc: %02d %02d %02d %02d %02d %02d %02d %02d \r\n", adc[0],adc[1],adc[2],adc[3],adc[4],adc[5],adc[6],adc[7]);
        }

        main_loop_counter++;
        Cpu_Delay100US(10000/128); //delay 1/128 s
         */
  }

  /*** Processor Expert end of main routine. DON'T MODIFY THIS CODE!!! ***/
  for(;;){}
  /*** Processor Expert end of main routine. DON'T WRITE CODE BELOW!!! ***/
} /*** End of main routine. DO NOT MODIFY THIS TEXT!!! ***/

/* END Project_2 */
/*
** ###################################################################
**
**     This file was created by Processor Expert 3.02 [04.44]
**     for the Freescale HCS12 series of microcontrollers.
**
** ###################################################################
*/
