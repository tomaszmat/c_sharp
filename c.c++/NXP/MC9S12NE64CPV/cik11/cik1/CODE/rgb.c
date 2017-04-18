/** ###################################################################
**     THIS COMPONENT MODULE IS GENERATED BY THE TOOL. DO NOT MODIFY IT.
**     Filename  : rgb.c
**     Project   : cik1
**     Processor : MC9S12NE64CPV
**     Component : BitsIO
**     Version   : Component 02.102, Driver 03.14, CPU db: 2.87.134
**     Compiler  : CodeWarrior HC12 C Compiler
**     Date/Time : 2017-03-13, 16:37
**     Abstract  :
**         This component "BitsIO" implements a multi-bit input/output.
**         It uses selected pins of one 1-bit to 8-bit port.
**         Note: This component is set to work in Output direction only.
**     Settings  :
**         Port name                   : A
**
**         Bit mask of the port        : $0007
**         Number of bits/pins         : 3
**         Single bit numbers          : 0 to 2
**         Values range                : 0 to 7
**
**         Initial direction           : Output (direction cannot be changed)
**         Initial output value        : 0 = 000H
**         Initial pull option         : off
**
**         Port data register          : PORTA     [$0000]
**         Port control register       : DDRA      [$0002]
**
**             ----------------------------------------------------
**                   Bit     |   Pin   |   Name
**             ----------------------------------------------------
**                    0      |    60   |   PA0_ADDR8_DATA8
**                    1      |    61   |   PA1_ADDR9_DATA9
**                    2      |    62   |   PA2_ADDR10_DATA10
**             ----------------------------------------------------
**
**         Optimization for            : speed
**     Contents  :
**         GetDir - bool rgb_GetDir(void);
**         GetVal - byte rgb_GetVal(void);
**         PutVal - void rgb_PutVal(byte Val);
**         GetBit - bool rgb_GetBit(byte Bit);
**         PutBit - void rgb_PutBit(byte Bit, bool Val);
**         SetBit - void rgb_SetBit(byte Bit);
**         ClrBit - void rgb_ClrBit(byte Bit);
**         NegBit - void rgb_NegBit(byte Bit);
**
**     Copyright : 1997 - 2010 Freescale Semiconductor, Inc. All Rights Reserved.
**     
**     http      : www.freescale.com
**     mail      : support@freescale.com
** ###################################################################*/

/* MODULE rgb. */

#include "rgb.h"
  /* Including shared modules, which are used in the whole project */
#include "PE_Types.h"
#include "PE_Error.h"
#include "PE_Const.h"
#include "IO_Map.h"
#include "Cpu.h"

#pragma DATA_SEG rgb_DATA              /* Select data segment "rgb_DATA" */
#pragma CODE_SEG rgb_CODE
#pragma CONST_SEG rgb_CONST            /* Constant section for this module */
/*
** ===================================================================
**     Method      :  rgb_GetMsk (component BitsIO)
**
**     Description :
**         The method returns a bit mask which corresponds to the 
**         required bit position.
**         This method is internal. It is used by Processor Expert only.
** ===================================================================
*/
static const byte rgb_Table[3U] = {    /* Table of mask constants */
   0x01U, 0x02U, 0x04U
};

static byte rgb_GetMsk (byte PinIndex)
{
  return (byte)((PinIndex<3U) ? rgb_Table[PinIndex] : 0U); /* Check range and return appropriate bit mask */
}

/*
** ===================================================================
**     Method      :  rgb_GetVal (component BitsIO)
**
**     Description :
**         This method returns an input value.
**           a) direction = Input  : reads the input value from the
**                                   pins and returns it
**           b) direction = Output : returns the last written value
**         Note: This component is set to work in Output direction only.
**     Parameters  : None
**     Returns     :
**         ---        - Input value (0 to 7)
** ===================================================================
*/
byte rgb_GetVal(void)
{
  return (byte)(getReg8(PORTA) & 0x07U); /* Return port data */
}

/*
** ===================================================================
**     Method      :  rgb_PutVal (component BitsIO)
**
**     Description :
**         This method writes the new output value.
**     Parameters  :
**         NAME       - DESCRIPTION
**         Val        - Output value (0 to 7)
**     Returns     : Nothing
** ===================================================================
*/
void rgb_PutVal(byte Val)
{
  Val &= 0x07U;                        /* Mask output value */
  setReg8(PORTA, (getReg8(PORTA) & (byte)(~(byte)0x07U)) | Val); /* Put masked value on port */
}

/*
** ===================================================================
**     Method      :  rgb_GetBit (component BitsIO)
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
**         Bit        - Number of the bit to read (0 to 2)
**     Returns     :
**         ---        - Value of the specified bit (FALSE or TRUE)
**                      FALSE = "0" or "Low", TRUE = "1" or "High"
** ===================================================================
*/
bool rgb_GetBit(byte Bit)
{
  byte const Mask = rgb_GetMsk(Bit);   /* Temporary variable - bit mask to test */
  return (bool)(((getReg8(PORTA) & Mask) == Mask)? 1U: 0U); /* Test if specified bit of port register is set */
}

/*
** ===================================================================
**     Method      :  rgb_PutBit (component BitsIO)
**
**     Description :
**         This method writes the new value to the specified bit
**         of the output value.
**     Parameters  :
**         NAME       - DESCRIPTION
**         Bit        - Number of the bit (0 to 2)
**         Val        - New value of the bit (FALSE or TRUE)
**                      FALSE = "0" or "Low", TRUE = "1" or "High"
**     Returns     : Nothing
** ===================================================================
*/
void rgb_PutBit(byte Bit, bool Val)
{
  byte const Mask = rgb_GetMsk(Bit);   /* Temporary variable - put bit mask */
  if (Val) {
    setReg8Bits(PORTA, Mask);          /* [bit (Bit)]=0x01U */
  } else { /* !Val */
    clrReg8Bits(PORTA, Mask);          /* [bit (Bit)]=0x00U */
  } /* !Val */
}

/*
** ===================================================================
**     Method      :  rgb_ClrBit (component BitsIO)
**
**     Description :
**         This method clears (sets to zero) the specified bit
**         of the output value.
**         [ It is the same as "PutBit(Bit,FALSE);" ]
**     Parameters  :
**         NAME       - DESCRIPTION
**         Bit        - Number of the bit to clear (0 to 2)
**     Returns     : Nothing
** ===================================================================
*/
void rgb_ClrBit(byte Bit)
{
  byte const Mask = rgb_GetMsk(Bit);   /* Temporary variable - set bit mask */
  clrReg8Bits(PORTA, Mask);            /* [bit (Bit)]=0x00U */
}

/*
** ===================================================================
**     Method      :  rgb_SetBit (component BitsIO)
**
**     Description :
**         This method sets (sets to one) the specified bit of the
**         output value.
**         [ It is the same as "PutBit(Bit,TRUE);" ]
**     Parameters  :
**         NAME       - DESCRIPTION
**         Bit        - Number of the bit to set (0 to 2)
**     Returns     : Nothing
** ===================================================================
*/
void rgb_SetBit(byte Bit)
{
  byte const Mask = rgb_GetMsk(Bit);   /* Temporary variable - set bit mask */
  setReg8Bits(PORTA, Mask);            /* [bit (Bit)]=0x01U */
}

/*
** ===================================================================
**     Method      :  rgb_NegBit (component BitsIO)
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
void rgb_NegBit(byte Bit)
{
  byte const Mask = rgb_GetMsk(Bit);   /* Temporary variable - set bit mask */
  invertReg8Bits(PORTA, Mask);         /* [bit (Bit)]=invert */
}

/*
** ===================================================================
**     Method      :  rgb_GetDir (component BitsIO)
**
**     Description :
**         This method returns direction of the component.
**     Parameters  : None
**     Returns     :
**         ---        - Direction of the component (always TRUE, Output only)
**                      FALSE = Input, TRUE = Output
** ===================================================================
*/
/*
bool rgb_GetDir(void)

**  This method is implemented as a macro. See rgb.h file.  **
*/


/* END rgb. */
/*
** ###################################################################
**
**     This file was created by Processor Expert 3.02 [04.44]
**     for the Freescale HCS12 series of microcontrollers.
**
** ###################################################################
*/