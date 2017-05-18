

/*define here your device,
for example
#define L152RE
*/
#define STM32L152RET

#if defined(STM32L152RET)
	#include "main.h"
	#include "gpio.h"
	#include "spi.h"
	#include "stm32l1xx_hal_spi.h"
	#include "stm32l152xe.h"
#endif


#if defined(MC9S08QE4)|| defined(MC9S12NE64CPV) || defined(MC9S08QE16CLC) || defined(MC9S08QE32)
	#include "..h"
#endif

#if !defined(MC9S08QE4) && !defined(MC9S12NE64CPV) && !defined(MC9S08QE16CLC) && !defined(MC9S08QE32) && !defined(STM32L152RET)
    #error "Choose device!"
#endif


void RFM7x_CE( unsigned char _value )
{
  #if defined(MC9S08QE4)|| defined(MC9S12NE64CPV) || defined(MC9S08QE16CLC) || defined(MC9S08QE32)
	   rf_ce_PutVal(v);
  #endif
  #if defined(STM32L152RET)
     HAL_GPIO_WritePin(rf_ce_GPIO_Port, rf_ce_Pin, _value);
  #endif
}

void RFM7x_CSN( unsigned char _value )
{
  #if defined(MC9S08QE4)|| defined(MC9S12NE64CPV) || defined(MC9S08QE16CLC) || defined(MC9S08QE32)
	   rf_nss_PutVal(_value);
  #endif
  #if defined(STM32L152RET)
      HAL_GPIO_WritePin(rf_nss_GPIO_Port, rf_nss_Pin, _value);
  #endif
}


void RFM7x_WAIT_MS (unsigned short ms)
{
  #if defined(MC9S08QE4)|| defined(MC9S12NE64CPV) || defined(MC9S08QE16CLC) || defined(MC9S08QE32)
      Cpu_Delay100US(10 * ms);
  #endif
  #if defined(STM32L152RET)
     HAL_Delay(10*ms);
  #endif
}


unsigned char rfm7x_SPI_RW( unsigned char value )
{
  #if defined(MC9S08QE4) || defined(MC9S08QE16CLC) || defined(MC9S08QE32)
      while(!SPIS_SPTEF);
      SPID = value;
      while(!SPIS_SPRF);
      return SPID;
  #endif

  #if defined(MC9S12NE64CPV)
      while(!SPISR_SPTEF);
      SPIDR = value;
      while(!SPISR_SPIF);
      return SPIDR;
  #endif

  #if defined(STM32L152RET)

      uint8_t  RXdata[2];
      uint8_t  TXdata[2];

      TXdata[0] = value;

      HAL_SPI_TransmitReceive(&hspi2, TXdata, RXdata, 1, 0);

      return RXdata[0];
  #endif
}
