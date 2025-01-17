/** ###################################################################
**     THIS COMPONENT MODULE IS GENERATED BY THE TOOL. DO NOT MODIFY IT.
**     Filename  : rf_irq.h
**     Project   : Project_2
**     Processor : MC9S12NE64CPV
**     Component : BitIO
**     Version   : Component 02.075, Driver 03.15, CPU db: 2.87.134
**     Compiler  : CodeWarrior HC12 C Compiler
**     Date/Time : 2017-03-27, 17:06
**     Abstract  :
**         This component "BitIO" implements an one-bit input/output.
**         It uses one bit/pin of a port.
**         Note: This component is set to work in Input direction only.
**         Methods of this component are mostly implemented as a macros
**         (if supported by target language and compiler).
**     Settings  :
**         Used pin                    :
**             ----------------------------------------------------
**                Number (on package)  |    Name
**             ----------------------------------------------------
**                       55            |  PE1_IRQ
**             ----------------------------------------------------
**
**         Port name                   : E
**
**         Bit number (in port)        : 1
**         Bit mask of the port        : $0002
**
**         Initial direction           : Input (direction cannot be changed)
**         Initial output value        : 0
**         Initial pull option         : off
**
**         Port data register          : PORTE     [$0008]
**         Port control register       : DDRE      [$0009]
**         Port function register      : INTCR     [$001E]
**
**         Optimization for            : speed
**     Contents  :
**         GetVal - bool rf_irq_GetVal(void);
**
**     Copyright : 1997 - 2010 Freescale Semiconductor, Inc. All Rights Reserved.
**     
**     http      : www.freescale.com
**     mail      : support@freescale.com
** ###################################################################*/

#ifndef rf_irq_H_
#define rf_irq_H_

/* MODULE rf_irq. */

  /* Including shared modules, which are used in the whole project */
#include "PE_Types.h"
#include "PE_Error.h"
#include "PE_Const.h"
#include "IO_Map.h"
#include "Cpu.h"

#pragma CODE_SEG rf_irq_CODE
/*
** ===================================================================
**     Method      :  rf_irq_GetVal (component BitIO)
**
**     Description :
**         This method returns an input value.
**           a) direction = Input  : reads the input value from the
**                                   pin and returns it
**           b) direction = Output : returns the last written value
**         Note: This component is set to work in Input direction only.
**     Parameters  : None
**     Returns     :
**         ---             - Input value. Possible values:
**                           FALSE - logical "0" (Low level)
**                           TRUE - logical "1" (High level)

** ===================================================================
*/
#define rf_irq_GetVal() ( \
    (bool)((getReg8(PORTE) & 0x02U))   /* Return port data */ \
  )

#pragma CODE_SEG DEFAULT

/* END rf_irq. */
#endif /* #ifndef __rf_irq_H_ */
/*
** ###################################################################
**
**     This file was created by Processor Expert 3.02 [04.44]
**     for the Freescale HCS12 series of microcontrollers.
**
** ###################################################################
*/
