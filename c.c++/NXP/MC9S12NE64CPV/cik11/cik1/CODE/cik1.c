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
#include "sw1.h"
#include "TI1.h"
#include "leds.h"
#include "SCI2.h"
#include "rgb.h"
/* Include shared modules, which are used for whole project */
#include "PE_Types.h"
#include "PE_Error.h"
#include "PE_Const.h"
#include "IO_Map.h"

/* User includes (#include below this line is not maintained by Processor Expert) */
 
 uint8_t counter;
 extern uint8_t val_r;
 //extern uint8_t val_g;
 //extern uint8_t val_b;
 char response[20] = "Odebralem polecenie";
 
 
 // Checking button
 void button_check() 
 {
                  if(sw1_GetVal() == 0)
                  {
                        Cpu_Delay100US(100);  //delay 10ms
                         if(sw1_GetVal() == 0) {leds_PutVal(counter++);}
                  }
 }
 
 // Sending char by uart
 void UART_SendChar(char c)
 {
     while(!SCI0SR1_TC); // check if last transfer end, go to send 
     SCI0DRL = c;
 }
 
 // Sending string  by uart
 void UART_SendString(char *buffor, uint8_t size) 
 {
      uint8_t _increment;
      for(_increment = 0; _increment<size; _increment++)
       {
           UART_SendChar(buffor[_increment]);
       }
 }
 
 // Uart ISR
 #pragma CODE_SEG __NEAR_SEG NON_BANKED 
 ISR(UART_Rx) 
 {
    byte s = SCI0SR1; // read register for correct ISR handlig
    byte d = SCI0DRL; // read recive sign
    
    switch(d) 
    {
      
      case '0': if( val_r<99) ++val_r; break;
      case '1': if( val_r>1) --val_r;  break;
      /*
      case '2': if( val_g<99) ++val_g; break;
      case '3': if( val_g>1) --val_g;  break;
      case '4': if( val_b<99) ++val_b; break;
      case '5': if( val_b>1) --val_b;  break;
      */
    }
    //UART_SendChar(d);
    /*
    if(d == 'H') { UART_SendString(response, 19); } 
    else if(d == '0') {   leds_PutVal(~(0b00000001));}
    else if(d == '1') {   leds_PutVal(~(0b00000010));}
    else if(d == '2') {   leds_PutVal(~(0b00000100));}
    else if(d == '3') {   leds_PutVal(~(0b00001000));}
    else if(d == '4') {   leds_PutVal(~(0b00010000));}
    else if(d == '5') {   leds_PutVal(~(0b00100000));}
    else if(d == '6') {   leds_PutVal(~(0b01000000));}
    else if(d == '7') {   leds_PutVal(~(0b10000000));}
    */
    //else if(d == 'r') {   A0_PutVal(1);}
  //  else if(d == 'g') {   A1_PutVal(1);}
  //  else if(d == 'R') {   A0_PutVal(0);}
    //else if(d == 'G') {   A1_PutVal(0);}
    
      
      
 }
 #pragma CODE_SEG DEFAULT

/*
bool isLeap(int _year) {
  return false;
}
 

void test()
{
      assert(isLeap(1999) = false);
      assert(isLeap(2004) = true);
      assert(isLeap(1997) = false);
      assert(isLeap(1100) = false);
 }
 */
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
     // leds_PutVal(~(0b00000000));
     // A0_PutVal( 0 ); 
     // A1_PutVal( 0 ); 
     
     // test();
     
     
   for(;;)  // Execute code in polling
   {
         //rgb_PutBit(0,TRUE);
        // rgb_PutBit(1,TRUE);
         //rgb_PutBit(2,TRUE);
        //button_check();
     // leds_PutVal(0b11010101);

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
