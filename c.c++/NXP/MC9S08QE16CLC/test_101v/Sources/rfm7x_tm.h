/*
 * rfm7x_tm.h
 *
 *  Created on: 9 maj 2017
 *      Author: bluemann
 */

#ifndef RFM7X_TM_H_
#define RFM7X_TM_H_

void RFM7x_CE( unsigned char _value );
void RFM7x_CSN( unsigned char _value );
void RFM7x_WAIT_MS (unsigned short ms);
unsigned char rfm7x_SPI_RW( unsigned char value );

#endif /* RFM7X_TM_H_ */
