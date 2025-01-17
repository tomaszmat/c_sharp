/** ###################################################################
**     THIS COMPONENT MODULE IS GENERATED BY THE TOOL. DO NOT MODIFY IT.
**     Filename  : leds.h
**     Project   : Project_2
**     Processor : MC9S12NE64CPV
**     Component : BitsIO
**     Version   : Component 02.102, Driver 03.14, CPU db: 2.87.134
**     Compiler  : CodeWarrior HC12 C Compiler
**     Date/Time : 2013-12-02, 12:18
**     Abstract  :
**         This component "BitsIO" implements a multi-bit input/output.
**         It uses selected pins of one 1-bit to 8-bit port.
**         Note: This component is set to work in Output direction only.
**     Settings  :
**         Port name                   : L
**
**         Bit mask of the port        : $007F
**         Number of bits/pins         : 7
**         Single bit numbers          : 0 to 6
**         Values range                : 0 to 127
**
**         Initial direction           : Output (direction cannot be changed)
**         Initial output value        : 0 = 000H
**         Initial pull option         : off
**
**         Port data register          : PTL       [$0268]
**         Port control register       : DDRL      [$026A]
**
**             ----------------------------------------------------
**                   Bit     |   Pin   |   Name
**             ----------------------------------------------------
**                    0      |    84   |   PL0_ACTLED
**                    1      |    83   |   PL1_LNKLED
**                    2      |    81   |   PL2_SPDLED
**                    3      |    59   |   PL3_DUPLED
**                    4      |    58   |   PL4_COLLED
**                    5      |    52   |   PL5
**                    6      |    51   |   PL6
**             ----------------------------------------------------
**
**         Optimization for            : speed
**     Contents  :
**         GetDir - bool leds_GetDir(void);
**         GetVal - byte leds_GetVal(void);
**         PutVal - void leds_PutVal(byte Val);
**         GetBit - bool leds_GetBit(byte Bit);
**         PutBit - void leds_PutBit(byte Bit, bool Val);
**         SetBit - void leds_SetBit(byte Bit);
**         ClrBit - void leds_ClrBit(byte Bit);
**         NegBit - void leds_NegBit(byte Bit);
**
**     Copyright : 1997 - 2010 Freescale Semiconductor, Inc. All Rights Reserved.
**     
**     http      : www.freescale.com
**     mail      : support@freescale.com
** ###################################################################*/

#ifndef leds_H_
#define leds_H_

/* MODULE leds. */

  /* Including shared modules, which are used in the whole project */
#include "PE_Types.h"
#include "PE_Error.h"
#include "PE_Const.h"
#include "IO_Map.h"
#include "Cpu.h"

#pragma CODE_SEG leds_CODE
/*
** ===================================================================
**     Method      :  leds_GetVal (component BitsIO)
**
**     Description :
**         This method returns an input value.
**           a) direction = Input  : reads the input value from the
**                                   pins and returns it
**           b) direction = Output : returns the last written value
**         Note: This component is set to work in Output direction only.
**     Parameters  : None
**     Returns     :
**         ---        - Input value (0 to 127)
** ===================================================================
*/
byte leds_GetVal(void);

/*
** ===================================================================
**     Method      :  leds_PutVal (component BitsIO)
**
**     Description :
**         This method writes the new output value.
**     Parameters  :
**         NAME       - DESCRIPTION
**         Val        - Output value (0 to 127)
**     Returns     : Nothing
** ===================================================================
*/
void leds_PutVal(byte Val);

/*
** ===================================================================
**     Method      :  leds_GetBit (component BitsIO)
**
**     Description :
**         This method returns the specified bit of the input value.
**           a) direction = Input  : reads the input value from pins
**                                   and returns the specified bit
**           b) direction = Output : returns the specified bit
**                                   of the last written value
**         Note: This component is set to work in Output direction only.
**     Parameters  :
**         NAME       - DESCRIPTION
**         Bit        - Number of the bit to read (0 to 6)
**     Returns     :
**         ---        - Value of the specified bit (FALSE or TRUE)
**                      FALSE = "0" or "Low", TRUE = "1" or "High"
** ===================================================================
*/
bool leds_GetBit(byte Bit);

/*
** ===================================================================
**     Method      :  leds_PutBit (component BitsIO)
**
**     Description :
**         This method writes the new value to the specified bit
**         of the output value.
**     Parameters  :
**         NAME       - DESCRIPTION
**         Bit        - Number of the bit (0 to 6)
**         Val        - New value of the bit (FALSE or TRUE)
**                      FALSE = "0" or "Low", TRUE = "1" or "High"
**     Returns     : Nothing
** ===================================================================
*/
void leds_PutBit(byte Bit, bool Val);

/*
** ===================================================================
**     Method      :  leds_ClrBit (component BitsIO)
**
**     Description :
**         This method clears (sets to zero) the specified bit
**         of the output value.
**         [ It is the same as "PutBit(Bit,FALSE);" ]
**     Parameters  :
**         NAME       - DESCRIPTION
**         Bit        - Number of the bit to clear (0 to 6)
**     Returns     : Nothing
** ===================================================================
*/
void leds_ClrBit(byte Bit);

/*
** ===================================================================
**     Method      :  leds_SetBit (component BitsIO)
**
**     Description :
**         This method sets (sets to one) the specified bit of the
**         output value.
**         [ It is the same as "PutBit(Bit,TRUE);" ]
**     Parameters  :
**         NAME       - DESCRIPTION
**         Bit        - Number of the bit to set (0 to 6)
**     Returns     : Nothing
** ===================================================================
*/
void leds_SetBit(byte Bit);

/*
** ===================================================================
**     Method      :  leds_NegBit (component BitsIO)
**
**     Description :
**         This method negates (inverts) the specified bit of the
**         output value.
**     Parameters  :
**         NAME       - DESCRIPTION
**         Bit        - Number of the bit to invert (0 to 31)
**     Returns     : Nothing
** ===================================================================
*/
void leds_NegBit(byte Bit);

/*
** ===================================================================
**     Method      :  leds_GetDir (component BitsIO)
**
**     Description :
**         This method returns direction of the component.
**     Parameters  : None
**     Returns     :
**         ---        - Direction of the component (always TRUE, Output only)
**                      FALSE = Input, TRUE = Output
** ===================================================================
*/
#define leds_GetDir() ( \
    (bool)1U                           /* Pins are fixed to GPO mode */ \
  )

#pragma CODE_SEG DEFAULT

/* END leds. */
#endif /* #ifndef __leds_H_ */
/*
** ###################################################################
**
**     This file was created by Processor Expert 3.02 [04.44]
**     for the Freescale HCS12 series of microcontrollers.
**
** ###################################################################
*/
