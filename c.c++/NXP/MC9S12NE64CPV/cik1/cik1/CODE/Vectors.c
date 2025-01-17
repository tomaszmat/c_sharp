/** ###################################################################
**     THIS COMPONENT MODULE IS GENERATED BY THE TOOL. DO NOT MODIFY IT.
**     Filename  : Vectors.c
**     Project   : cik1
**     Processor : MC9S12NE64CPV
**     Version   : Component 02.001, Driver 02.06, CPU db: 2.87.134
**     Compiler  : CodeWarrior HC12 C Compiler
**     Date/Time : 2017-03-20, 09:25
**     Abstract  :
**         This component "MC9S12NE64_112" implements properties, methods,
**         and events of the CPU.
**     Settings  :
**
**
**     Copyright : 1997 - 2010 Freescale Semiconductor, Inc. All Rights Reserved.
**     
**     http      : www.freescale.com
**     mail      : support@freescale.com
** ###################################################################*/
#include "Cpu.h"
#include "sw1.h"
#include "PWMtimer.h"
#include "leds.h"
#include "SCI2.h"
#include "rgb.h"

/* ISR prototype */
typedef void (*near tIsrFunc)(void);
/*lint -save  -e950 Disable MISRA rule (1.1) checking. */
static const tIsrFunc _InterruptVectorTable[] @0xFF80U = { /* Interrupt vector table */
/*lint -restore Enable MISRA rule (1.1) checking. */
  /* ISR name                               No. Address Pri Name          Description */
  &Cpu_Interrupt,                      /* 0x3F  0xFF80   1  ivVReserved63 unused by PE */
  &Cpu_Interrupt,                      /* 0x3E  0xFF82   1  ivVReserved62 unused by PE */
  &Cpu_Interrupt,                      /* 0x3D  0xFF84   1  ivVReserved61 unused by PE */
  &Cpu_Interrupt,                      /* 0x3C  0xFF86   1  ivVReserved60 unused by PE */
  &Cpu_Interrupt,                      /* 0x3B  0xFF88   1  ivVReserved59 unused by PE */
  &Cpu_Interrupt,                      /* 0x3A  0xFF8A   1  ivVReserved58 unused by PE */
  &Cpu_Interrupt,                      /* 0x39  0xFF8C   1  ivVReserved57 unused by PE */
  &Cpu_Interrupt,                      /* 0x38  0xFF8E   1  ivVReserved56 unused by PE */
  &Cpu_Interrupt,                      /* 0x37  0xFF90   1  ivVReserved55 unused by PE */
  &Cpu_Interrupt,                      /* 0x36  0xFF92   1  ivVReserved54 unused by PE */
  &Cpu_Interrupt,                      /* 0x35  0xFF94   1  ivVReserved53 unused by PE */
  &Cpu_Interrupt,                      /* 0x34  0xFF96   1  ivVReserved52 unused by PE */
  &Cpu_Interrupt,                      /* 0x33  0xFF98   1  ivVReserved51 unused by PE */
  &Cpu_Interrupt,                      /* 0x32  0xFF9A   1  ivVReserved50 unused by PE */
  &Cpu_Interrupt,                      /* 0x31  0xFF9C   1  ivVReserved49 unused by PE */
  &Cpu_Interrupt,                      /* 0x30  0xFF9E   1  ivVReserved48 unused by PE */
  &Cpu_Interrupt,                      /* 0x2F  0xFFA0   1  ivVemacec     unused by PE */
  &Cpu_Interrupt,                      /* 0x2E  0xFFA2   1  ivVemaclc     unused by PE */
  &Cpu_Interrupt,                      /* 0x2D  0xFFA4   1  ivVemacbrxerr unused by PE */
  &Cpu_Interrupt,                      /* 0x2C  0xFFA6   1  ivVemacrxbbo  unused by PE */
  &Cpu_Interrupt,                      /* 0x2B  0xFFA8   1  ivVemacrxbao  unused by PE */
  &Cpu_Interrupt,                      /* 0x2A  0xFFAA   1  ivVemacrxerr  unused by PE */
  &Cpu_Interrupt,                      /* 0x29  0xFFAC   1  ivVemacmii    unused by PE */
  &Cpu_Interrupt,                      /* 0x28  0xFFAE   1  ivVemacrxfc   unused by PE */
  &Cpu_Interrupt,                      /* 0x27  0xFFB0   1  ivVemactxc    unused by PE */
  &Cpu_Interrupt,                      /* 0x26  0xFFB2   1  ivVemacrxbbc  unused by PE */
  &Cpu_Interrupt,                      /* 0x25  0xFFB4   1  ivVemacrxbac  unused by PE */
  &Cpu_Interrupt,                      /* 0x24  0xFFB6   1  ivVephy       unused by PE */
  &Cpu_Interrupt,                      /* 0x23  0xFFB8   1  ivVflash      unused by PE */
  &Cpu_Interrupt,                      /* 0x22  0xFFBA   1  ivVReserved34 unused by PE */
  &Cpu_Interrupt,                      /* 0x21  0xFFBC   1  ivVReserved33 unused by PE */
  &Cpu_Interrupt,                      /* 0x20  0xFFBE   1  ivVReserved32 unused by PE */
  &Cpu_Interrupt,                      /* 0x1F  0xFFC0   1  ivViic        unused by PE */
  &Cpu_Interrupt,                      /* 0x1E  0xFFC2   1  ivVReserved30 unused by PE */
  &Cpu_Interrupt,                      /* 0x1D  0xFFC4   1  ivVcrgscm     unused by PE */
  &Cpu_Interrupt,                      /* 0x1C  0xFFC6   1  ivVcrgplllck  unused by PE */
  &Cpu_Interrupt,                      /* 0x1B  0xFFC8   1  ivVReserved27 unused by PE */
  &Cpu_Interrupt,                      /* 0x1A  0xFFCA   1  ivVportg      unused by PE */
  &Cpu_Interrupt,                      /* 0x19  0xFFCC   1  ivVporth      unused by PE */
  &Cpu_Interrupt,                      /* 0x18  0xFFCE   1  ivVportj      unused by PE */
  &Cpu_Interrupt,                      /* 0x17  0xFFD0   1  ivVReserved23 unused by PE */
  &Cpu_Interrupt,                      /* 0x16  0xFFD2   1  ivVatd        unused by PE */
  &Cpu_Interrupt,                      /* 0x15  0xFFD4   1  ivVsci1       unused by PE */
  &UART_Rx,                            /* 0x14  0xFFD6   1  ivVsci0       used by PE */
  &Cpu_Interrupt,                      /* 0x13  0xFFD8   1  ivVspi        unused by PE */
  &Cpu_Interrupt,                      /* 0x12  0xFFDA   1  ivVtimpaie    unused by PE */
  &Cpu_Interrupt,                      /* 0x11  0xFFDC   1  ivVtimpaovf   unused by PE */
  &Cpu_Interrupt,                      /* 0x10  0xFFDE   1  ivVtimovf     unused by PE */
  &Cpu_Interrupt,                      /* 0x0F  0xFFE0   1  ivVtimch7     unused by PE */
  &Cpu_Interrupt,                      /* 0x0E  0xFFE2   1  ivVtimch6     unused by PE */
  &Cpu_Interrupt,                      /* 0x0D  0xFFE4   1  ivVtimch5     unused by PE */
  &PWMtimer_Interrupt,                 /* 0x0C  0xFFE6   1  ivVtimch4     used by PE */
  &Cpu_Interrupt,                      /* 0x0B  0xFFE8   1  ivVReserved11 unused by PE */
  &Cpu_Interrupt,                      /* 0x0A  0xFFEA   1  ivVReserved10 unused by PE */
  &Cpu_Interrupt,                      /* 0x09  0xFFEC   1  ivVReserved9  unused by PE */
  &Cpu_Interrupt,                      /* 0x08  0xFFEE   1  ivVReserved8  unused by PE */
  &Cpu_Interrupt,                      /* 0x07  0xFFF0   1  ivVrti        unused by PE */
  &Cpu_Interrupt,                      /* 0x06  0xFFF2   1  ivVirq        unused by PE */
  &Cpu_Interrupt,                      /* 0x05  0xFFF4   -  ivVxirq       unused by PE */
  &Cpu_Interrupt,                      /* 0x04  0xFFF6   -  ivVswi        unused by PE */
  &Cpu_Interrupt,                      /* 0x03  0xFFF8   -  ivVtrap       unused by PE */
  /* Reset handler name */
  &_EntryPoint,                        /* 0x02  0xFFFA   -  ivVcop        unused by PE */
  &_EntryPoint,                        /* 0x01  0xFFFC   -  ivVclkmon     unused by PE */
  &_EntryPoint                         /* 0x00  0xFFFE   -  ivVreset      used by PE */
};
/*
** ###################################################################
**
**     This file was created by Processor Expert 3.02 [04.44]
**     for the Freescale HCS12 series of microcontrollers.
**
** ###################################################################
*/
