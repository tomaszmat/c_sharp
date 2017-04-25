/*
 * reg.h
 *
 *  Created on: 24 kwi 2017
 *      Author: bluemann
 */

#ifndef REG_H_
#define REG_H_

/* Initialize regulator  */
void PID_Init(double val_p, double val_i, double val_d);

/* Read Voltage/Current from Photo Diode */
void PID_Read();

/* Write Voltage/Current to Laser Diode */
void PID_Wrtie(double _val);

/* Calculate parameters */
void PID_Process();


#endif /* REG_H_ */
