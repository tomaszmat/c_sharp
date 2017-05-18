/*
 * ulp.h
 *
 *  Created on: May 17, 2017
 *      Author: bluemann
 */

#ifndef ULP_H_
#define ULP_H_


#define TEST

/* RTC Register Mnemonic Operands */
#define _RTC_CLEAN_IR_FLAG		RTCSC_RTIF = 1
#define _RTC_IR_ON				RTCSC |=(1<<RTCSC_RTIE)
/*  w rtc ¿eby dzia³a³o jak powino czyli wybudzanie
 *  z uœpienia itd to koncu kodu przerwania: 
 * 
 * 
 */
/* SPI Register Mnemonic Operands */
#define _SPI_ON					SPIC1 |= (1<<SPIC1_SPE)
#define _SPI_OFF				SPIC1 &= ~(1<<SPIC1_SPE)

/* Ports Register Mnemonic Operands */
#define _PTA3_AS_INPUT			PTADD &= ~ (1<< PTADD_PTADD3)
#define _PTA3_AS_OUTPUT			PTADD |= (1<<PTADD_PTADD3);

#define _PTA3_PULL_UP_ON		PTAPE |= (1<<PTAPE_PTAPE3)	  
#define _PTA3_PULL_UP_OFF		PTAPE &=~ (1<<PTAPE_PTAPE3)

#define _PORTB_PULL_UPS_OFF		PTBPE &=~ ((1<<PTBPE_PTBPE3)|(1<<PTBPE_PTBPE4)|(1<<PTBPE_PTBPE5)|(1<<PTBPE_PTBPE2)|(1<<PTBPE_PTBPE6))
#define _PORTB_PULL_UPS_ON		PTBPE |= ((1<<PTBPE_PTBPE3)|(1<<PTBPE_PTBPE4)|(1<<PTBPE_PTBPE5)|(1<<PTBPE_PTBPE2)|(1<<PTBPE_PTBPE6))

#define _PORTB_AS_OUTPUT		PTBDD |=((1<<PTBDD_PTBDD3)|(1<<PTBDD_PTBDD4)|(1<<PTBDD_PTBDD5)|(1<<PTBDD_PTBDD2)|(1<<PTBDD_PTBDD6))
#define _PORTB_SET_AT_OUTPUTS	PTBD  |=((1<<PTBD_PTBD3)|(1<<PTBD_PTBD4)|(1<<PTBD_PTBD5)|(1<<PTBD_PTBD2)|(1<<PTBD_PTBD6))


#endif /* ULP_H_ */
