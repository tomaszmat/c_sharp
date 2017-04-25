/*	 Created on: 24 kwi 2017
 *      Author: bluemann			*/

/* Includes */
#include <stdint.h>
#include <math.h>
/* Us includes */
#include "main.h"
#include "stm32l1xx_hal.h"
#include "adc.h"
#include "dac.h"
#include "gpio.h"

/* MCU/Board */
#define L152RE
#define PD

/* 			Regulator values 	*/
  const double p;
  const double i; // i = 4*0.05
  const double d; // if we measure on period 50ms => d = 0.05

/* 			Power values		*/
  double power_task 	= 0.0;
  double power_actually = 0.0;

/* 			Act Vars			*/
  double signal		= 0.0;
  double error		= 0.0;
  double error_past = 0.0;
  double time; // time of changes

  /* Bit to Voltage [V/bits]; 4096 bits on 3.3 [V] supply */
  const double bit_to_Voltage = 0.0008056640625;
  /* Voltage to Bit [ bits/V] */
  const double Voltage_to_bit = 1241.2121;

  double current_photodiode = 0.0;

  /* ============================ I - > U ===========================*/

  /* I -> U [Ohms] */
  const uint8_t R1 = 1000000;
  const uint8_t R2 = 18000;
  const uint8_t R3 = 10000000;

    /* Monitor Current to Power  [mW/mA] */
  const double alfa_I_P = 37.037;

  /* Calc LD power by PD current  */
  double _calc_power_laser(double _current_photodiode)
  {
	  double _power = 0.0;
	  _power = _current_photodiode * alfa_I_P;
	  return _power;
  }

 /* Calc Photodiode current on LM2903 2stage output */
  double _calc_current_photdiode(_voltage)
  {
	 /* *(-1) */
	  current_photodiode = (double)(_voltage/R1) * R2/(R2+R3);
	  return current_photodiode;
  }

  /* ============================ U - > I ===========================*/
  /* U -> I [Ohms]*/
    const uint8_t R4 = 100000;
    const uint8_t R5 = 100000;
    const uint8_t R6 = 22;

  /*Power Task to LD Current [mA/mW] */
   const double alfa_P_I = 0.7142;

  /* Calc Task current for LD from power */
  double _calc_current_laserdiode(double _power)
  {
	  double current_laserdiode = 0.0;
	  current_laserdiode = 0.7142*_power;
	  return current_laserdiode;
  }

  /* Calc Task voltage for LD from current */
  double _calc_DAC_out(double _current)
  {
 	 double vol = 0.0;
 	 vol = (R4+R5)/R5 * _current*R6; // *-1
 	 vol = round(Voltage_to_bit*vol);
 	 if(vol > 4095) vol = 0; // Report Error
 	 return vol;
  }

  /* ============================Regulator Program===========================*/
/* Initialize regulator  */
void PID_Init(double val_p, double val_i, double val_d)
{
	  p = val_p;
	  i = val_i;
      d = val_d;

	#ifdef L152RE
		  /*	Init DAC	*/
		  HAL_DAC_Start(hdac, DAC_CHANNEL_1);
		  /*	Init ADC	*/
		  HAL_ADC_Start(hadc);
	#else
		#error Choose MCU/Board
	#endif
}

/* Read Voltage/Current from Photo Diode */
double PID_Read()
{
	double _voltage = 0.0;

	#ifdef L152RE
		_voltage = bit_to_Voltage*HAL_ADC_GetValue(hadc);
	#else
		#error Choose MCU/Board
	#endif
			return _calc_power_laser(calc_current_photdiode(_voltage));

}

/* Write Voltage/Current to Laser Diode */
void PID_Write(double _power)
{
	uint8_t val = 0;
	_calc_DAC_out(_calc_current_laserdiode(_power));
	if(val<4096)
	{
		#ifdef L152RE
		HAL_DAC_SetValue(&hdac, DAC_CHANNEL_2, DAC_ALIGN_8B_R, _power);
		#else
			#error Choose MCU/Board
		#endif
	}
	else
	{
		/* Report Error */
	}
}

/* Calculate parameters */
void PID_Process()
{
	power_actually = PID_Read();

	error  =  power_task - power_actually;

	#ifdef PD
		signal = p * error + d * ((error - error_past)/time);
	#elif  PID
		signal = p * error + d * ((error - error_past)/time) +i * integrator(error);
	#elif PI
		signal = p * error + i * integrator(error);
	#else
		#error  Choose kind of regulator
	#endif

	error_past = error;
	PID_Write(signal);

}


