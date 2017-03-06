/** ###################################################################
**     THIS COMPONENT MODULE IS GENERATED BY THE TOOL. DO NOT MODIFY IT.
**     Filename  : A1.h
**     Project   : cik1
**     Processor : MC9S12NE64CPV
**     Component : BitIO
**     Version   : Component 02.075, Driver 03.15, CPU db: 2.87.134
**     Compiler  : CodeWarrior HC12 C Compiler
**     Date/Time : 2017-03-06, 10:13
**     Abstract  :
**         This component "BitIO" implements an one-bit input/output.
**         It uses one bit/pin of a port.
**         Note: This component is set to work in Output direction only.
**         Methods of this component are mostly implemented as a macros
**         (if supported by target language and compiler).
**     Settings  :
**         Used pin                    :
**             ----------------------------------------------------
**                Number (on package)  |    Name
**             ----------------------------------------------------
**                       61            |  PA1_ADDR9_DATA9
**             ----------------------------------------------------
**
**         Port name                   : A
**
**         Bit number (in port)        : 1
**         Bit mask of the port        : $0002
**
**         Initial direction           : Output (direction cannot be changed)
**         Initial output value        : 1
**         Initial pull option         : off
**
**         Port data register          : PORTA     [$0000]
**         Port control register       : DDRA      [$0002]
**
**         Optimization for            : speed
**     Contents  :
**         GetVal - bool A1_GetVal(void);
**         PutVal - void A1_PutVal(bool Val);
**         ClrVal - void A1_ClrVal(void);
**         SetVal - void A1_SetVal(void);
**         NegVal - void A1_NegVal(void);
**
**     Copyright : 1997 - 2010 Freescale Semiconductor, Inc. All Rights Reserved.
**     
**     http      : www.freescale.com
**     mail      : support@freescale.com
** ###################################################################*/

#ifndef A1_H_
#define A1_H_

/* MODULE A1. */

  /* Including shared modules, which are used in the whole project */
#include "PE_Types.h"
#include "PE_Error.h"
#include "PE_Const.h"
#include "IO_Map.h"
#include "Cpu.h"

#pragma CODE_SEG A1_CODE
/*
** ===================================================================
**     Method      :  A1_GetVal (component BitIO)
**
**     Description :
**         This method returns an input value.
**           a) direction = Input  : reads the input value from the
**                                   pin and returns it
**           b) direction = Output : returns the last written value
**         Note: This component is set to work in Output direction only.
**     Parameters  : None
**     Returns     :
**         ---             - Input value. Possible values:
**                           FALSE - logical "0" (Low level)
**                           TRUE - logical "1" (High level)

** ===================================================================
*/
#define A1_GetVal() ( \
    (bool)((getReg8(PORTA) & 0x02U))   /* Return port data */ \
  )

/*
** ===================================================================
**     Method      :  A1_PutVal (component BitIO)
**
**     Description :
**         This method writes the new output value.
**     Parameters  :
**         NAME       - DESCRIPTION
**         Val             - Output value. Possible values:
**                           FALSE - logical "0" (Low level)
**                           TRUE - logical "1" (High level)
**     Returns     : Nothing
** ===================================================================
*/
void A1_PutVal(bool Val);

/*
** ===================================================================
**     Method      :  A1_ClrVal (component BitIO)
**
**     Description :
**         This method clears (sets to zero) the output value.
**     Parameters  : None
**     Returns     : Nothing
** ===================================================================
*/
#define A1_ClrVal() ( \
    (void)clrReg8Bits(PORTA, 0x02U)    /* BIT1=0x00U */ \
  )

/*
** ===================================================================
**     Method      :  A1_SetVal (component BitIO)
**
**     Description :
**         This method sets (sets to one) the output value.
**     Parameters  : None
**     Returns     : Nothing
** ===================================================================
*/
#define A1_SetVal() ( \
    (void)setReg8Bits(PORTA, 0x02U)    /* BIT1=0x01U */ \
  )

/*
** ===================================================================
**     Method      :  A1_NegVal (component BitIO)
**
**     Description :
**         This method negates (inverts) the output value.
**     Parameters  : None
**     Returns     : Nothing
** ===================================================================
*/
#define A1_NegVal() ( \
    (void)invertReg8Bits(PORTA, 0x02U) /* BIT1=invert */ \
  )

#pragma CODE_SEG DEFAULT

/* END A1. */
#endif /* #ifndef __A1_H_ */
/*
** ###################################################################
**
**     This file was created by Processor Expert 3.02 [04.44]
**     for the Freescale HCS12 series of microcontrollers.
**
** ###################################################################
*/
