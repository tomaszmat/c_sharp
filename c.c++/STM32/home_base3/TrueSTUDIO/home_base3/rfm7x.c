//**************************************************************************
//
//! \mainpage rfm7x
//!
//! C interface library for the HopeRF RFM7x 4.3 GHz transceiver module
//!
//! \image html RFM7x-D.jpg
//! \image rtf RFM7x-D.jpg
//!
//! \author
//!    Wouter van Ooijen (wouter@voti.nl)
//!
//! \version
//!    V1.02 (2011-12-31)
//!
//! \par Introduction
//!
//! The RFM7x module from HopeRF (www.hoperf.com) is a small and cheap
//! transceiver (transmitter + receiver) module for the license-free
//! 4.3 MHz frequency band. This module is intended for short range
//! communication, for instance within a room.
//! Typical applications are wires mouses and keybords,
//! and garage door openers.
//! In open air a distance of
//! 50 .. 100 m is possible, but this is strictly line-of-sight: even
//! the leaves of a single tree can obstruct the signal.
//!
//! The two main files in this libary, rfm7x.h and rfm7x.c,
//! are target independent.
//! However, rfm7x.c included by a file that must be provided
//! by the user.
//! This file must provide macro's for initializing and accessing the
//! I/O pins that connect to the RFM7x module, and for
//! delays of a specified number of milliseconds and microseconds.
//! A template for this file is provided.
//!
//! \par Files
//! - rfm7x.h
//! - rfm7x.c
//! - rfm7x-config.h
//!
//!
//! \par License
//!
//! The files in this library are licensed under the zlib license,
//! which rougly says: when you redistribute the *source* you must
//! keep the copyright notice intact. Otherwise you can use these files
//! any way you like, including getting rich from selling applications.
//! But don't complain to me when it does not work (OTOH, contructive
//! comments are appreciated!).
//!
//! \par ToDo: bugs, notes, pitfalls, todo, known problems, etc
//!
//! - pictures for power
//! - document (other) files
//! - PIC18F examples, Cortex C examples, Arduino
//! - write 5 bytes when address <5 bytes?
//! - check and improve rtf documentation
//! - check CE cycling requirements
//! - descriptions for the other files
//! - add write ack payload for pipe N
//! - add 'report package has been sent'
//! - application: thermometer
//! - application: test signal strength
//! - application: asynch serial through the air
//!
//
//***************************************************************************//

//***************************************************************************//
//
// COPYRIGHT NOTICE (zlib license)
//
// Loosely based on the example application provided by HopeRF
//
// (c) Wouter van Ooijen - wouter@voti.nl
//
//  This software is provided 'as-is', without any express or implied
//  warranty.  In no event will the authors be held liable for any damages
//  arising from the use of this software.
//
//  Permission is granted to anyone to use this software for any purpose,
//  including commercial applications, and to alter it and redistribute it
//  freely, subject to the following restrictions:
//
//  1. The origin of this software must not be misrepresented; you must not
//     claim that you wrote the original software. If you use this software
//     in a product, an acknowledgment in the product documentation would be
//     appreciated but is not required.
//  2. Altered source versions must be plainly marked as such, and must not be
//     misrepresented as being the original software.
//  3. This notice may not be removed or altered from any source distribution.
//
//***************************************************************************//

//***************************************************************************//
//
//! \page revision information
//!
//! \par ToDo: bugs, notes, pitfalls, todo, known problems, etc
//!
//! - pictures for power
//! - document (other) files
//! - PIC18F examples, Cortex C examples, Arduino
//! - write 5 bytes when address <5 bytes?
//! - check and improve rtf documentation
//! - check CE cycling requirements
//! - descriptions for the other files
//! - add write ack payload for pipe N
//! - add 'report package has been sent'
//! - application: thermometer
//! - application: test signal strength
//! - application: asynch serial through the air
//!
//! \par release notes
//!
//! V1.02 (2011-12-31)
//! Arduino added
//!
//! V1.01 (2011-12-26)
//! some minor documentation and webpage changes, no code changes
//!
//! V1.00 (2011-12-24)
//! first release
//!
//
//***************************************************************************//

//***************************************************************************//
//
//! \page overview RFM7x overview
//!
//! \image html smd-pins.jpg
//! \image rtf smd-pins.jpg
//!
//! The RFM7x is a small module (PCB with some components, ~ 18 x 26 mm)
//! that implements a transciever for the license-free 4.3 GHz band.
//! The module contains a small antenna on the PCB,
//! there is no provision for an external antenna.
//! Two versions of the module exist, one with
//! pins and one without. The pins are on a 1.28 mm grid, which is twice the
//! density of a standard DIL package. The module requires 1.9 .. 3.6 Volt
//! for its power, 3.3 Volt seems to be the preferred operating voltage.
//! It is NOT designed to run at 5.0 Volt.
//! According to the datasheet that maximum 'typical' operating current
//! is 23 mA.
//!
//! Note that 'licence free' means that certain well-described use of this
//! frequency band is allowd without a license.
//! The RFM7x is designed to be compatible with the requirements for such
//! use, but it is the responsibility of anyone who sells a product that
//! to make sure that it complies with such rules.
//!
//! The main component of an RFM7x module is the RF7x chip (hidden beneath
//! the black blob). The manufacturer provides separate datasheets for both
//! the RF7x chip and the RFM7x module.
//! The two datasheets seem to be the same, except for the physical
//! and pinout information which is of course different for the chip
//! and the module, so you can probably ignore the RF7x chip datasheet.
//! The RFM7x module datasheet can currently be found at
//! http://www.hoperf.com/upload/rf/RFM7x.pdf
//!
//! The RFM7x module is intended for short-range communication,
//! like wireless computer peripherals (mouse, keyboard, tablet, ect.)
//! keyfobs (car opener, garage door opener, motorized fence opener -
//! some cryptografy will probably be required for such applications)
//! and toys. In a line of sight situation a maximum range of 50 .. 100 m
//! is possible. Indoors communication within a single room will generally
//! be OK (unless you have a very large room..) but passing even a single
//! wall can be a problem.
//!
//! An RFM7x module must be used with a microcontroller that initializes
//! and operates the module. By itself the module can not be used as a
//! 'wireless wire', although such a mode could be implemented in the
//! microcontroller. The interface between the RFM7x and the microcontroller
//! is a standard 4-PIN SPI interface (MISO, MOSI, CLCK, CSN) plus a CE
//! (Chip Enable) pin. The module also provides an IRQ pin that could be used
//! to speed up the detection of certain events within the module.
//! The library does not used this pin.
//! The SPI input pins are 5V-tolerant, so provided that
//! the high level as output by the module is accpetable to the
//! microcontroller no glue circuitry is needed to interface to a
//! microcontroller that runs from 5 Volt. (Except for course for a
//! regulator that provides the 3.3 Volt to power the RFM7x.)
//!
//! An RFM7x module operates in the 4.3 GHz band.
//! Within that band a frequency can be selected in 1 MHz steps.
//! RFM7x modules can communicate only when they use the same frequency.
//!
//! The RFM7x module operates on a packet basis.
//! Each packet has a destination address.
//! By default the address is a 5 byte value, but a 4 or 3 byte
//! address can also be configured.
//! For succesfull communication the RFM7x modules that are involved must
//! be configures for the same address length, and the receiving
//! module(s) must have one of their so-called pipes configured
//! for the address used by the transmitter.
//!
//! An RFM7x contains 6 so-called data pipes that can receive packages.
//! Each pipe has an address, and will receive only messages
//! for that address.
//! Pipes 0 and 1 have a full (up to 5 bytes) address.
//! For pipes 2 .. 6 only the least significant byte can be
//! configured, the other bytes are copied from the address of pipe 1.
//! The length of the address (3, 4 or 5 bytes) is the same for
//! transmission and for all 6 receive data pipes.
//!
//! A packet contains 1 .. 32 user data bytes.
//! The packet length can either be fixed or flexible.
//! When the packet length is fixed each receiving pipe is configured
//! with its packet length. The length of a package that is sent is
//! determined by the number of bytes written into the transmit buffer,
//! and it it must match the length configured for the receiving pipe.
//! When the packet length is flexible the length of a package is again
//! determined by the number of bytes written into the transmit, but in
//! this case this number is transmitted in the message, and on the
//! receiving side it can be retrieved by the R_RX_PL_WID command
//! (rfm7x_channel_payload_size function).
//!
//! The simple way to send a package is without acknowledgement.
//! The RFM7x just transmits the package and considers it done.
//! It can be received by zero, one, or multiple RFM7x modules, but
//! the sending modules does not care and has no way of knowing.
//! For this simple mode of communication the involved RFM7x's
//! - must be configured for the same channel frequency
//! - must use the same address length
//! - the receiving RFM7x must have a receive pipe configured
//!   for the same address as used by the transmitting RFM7x
//!
//! Alternatively a package can be sent with acknowledgement and
//! (if necessary) retransmission.
//! In this case the RFM7x will send the message, and consider it
//! done only when it receives an acknowledge for it.
//! If it does not receive an acknowledge within a fixed amount of
//! time it will re-transmit the package, up to a set maximum.
//! A receiving RFM7x can automatically send an acknowledgement
//! for a successfully received package.
//! For this to work the same requirements as for simple unacknowledged
//! communicatiobn apply, and additionally on both RFM7x's
//! - CRC must be enabled (length 1 or 2) on both modules
//! - receive data pipe 0 must be configured for the same address
//!   as the module uses for transmitting
//!
//! The automatic retransmission provided by the RFM7x uses a fixed
//! retransmission timout, which is probly fine for correcting an
//! occasional packet loss due to interference from other 4.3 GHz sources,
//! but it is potentially inefective when the interference is caused by
//! another RFM7x that uses the same timout! In such cases the
//! microcontroller should implemnet its own retransmission scheme,
//! with for instance a random timeout, and maybe an exponential
//! backoff.
//!
//
//***************************************************************************//

//***************************************************************************//
//
//! \page hardware RFM7x hardware interface
//!
//! \image html smd-pins.jpg
//! \image rtf smd-pins.jpg
//!
//! The RFM7x uses a standard 4-wire SPI interface.
//! It also provides an active low interrupt pin, which could be used to
//! avoid polling. This library does not use the interrupt pin.
//! The RFM7x also has a CE (chip enable) input, which must be de-asserted
//! to put the chip in standby or power-down mode, and must be cycled
//! to switch between receive and transmit mode. Hence the interface
//! uses 5 data pins, plus ground and power (3.3V):
//! - GND : common ground
//! - VDD : 3.3V power
//! - CE : Chip Enable, active high, microcontoller output
//! - CSN : Chip Select Negative, active low, microcontoller output
//! - SCK : Serial ClocK, microcontoller output
//! - MOSI : Master Out Slave In, microcontoller output
//! - MISO : Master In Slave Out, microcontoller input
//! - IRQ : Interrupt ReQuest, not used
//!
//! When the microcontroller operates at 3.3 Volt (or lower,
//! the RFM7x datasheet claims operation down to 1.9 Volt) all lines,
//! including power,
//! can be connected directly to the microcontroller.
//! If you are experimenting and want to protect yourself against
//! problems when you accidentally configure the pin connected to MISO
//! as output, you could insert a suitable series resistor in this line.
//! 2k2 seems to be a good choice.
//!
//! When the microcontroller operates at 5 Volt there are three possible issues:
//! - power : the RFM7x operates at 1.9 .. 3.3 Volt, so the 5 Volt must somehow
//!   be reduced to a voltage within this range
//! - data from the microcontroller to the RFM7x : no problem here, the
//!   RFM7x inputs are 5 Volt tolerant.
//!   As explained, a series resistor in the MISO line might be a good idea.
//! - data from RFM7x to the microcontroller : in most cases this will not
//!   be a problem, but you might want to check the minimum voltage required
//!   by your microcontroller to reliably detect a logic 1. For instance a
//!   PIC requires ~ 2.0 Volt on a TTL level input, but 0.8 * VDD on a
//!   Schmitt Trigger input! And you must consider this at the maximum VDD
//!   for the microcontroller, which can be 5.5 Volt when delivered by
//!   an 7805 or an USB port.
//!
//! There are various ways to create a 3.3 Volt supply for the RFM7x from a
//! 5 Volt supply. I prefer to use a low-drop low-quiecent
//! current 3.3 Volt linear regulator. Read the datasheet of the regulator
//! carefully: some put very stringent requirements on the value and impedance
//! of the decoupling capacitors. My favourite is the Microchip MCP17x2,
//! which has a low quiecent current (5 uA maximum), and is stable with
//! only 1 uF input an output capacitors of any type
//! (ceramic, tantalum, aluminium electrolytic).
//!
//! TBW: picture
//!
//! A crude way to create the power for the RFM7x is to use a
//! resistor divider. I would do this only in an experimental
//! setup on my desk, never in a final product.
//! The source impedance of the divider causes a drop in the
//! voltage when the RFM7x uses more current.
//! This drop can be reduced by lowering the resistor values, but at
//! the cost of a higher current through the resistors. The RFM7x
//! can operate down to 1.9 Volt, but at that level the microcontroller
//! might not reliably recognise a logic 1 from the RFM7x. Another issue
//! is the dissipation in the resistors. The circuit below is a compromise.
//! It uses three equal-valued resistors because I don't stock many
//! different resistor values.
//! The idle current through the resistors is 83 mA at 5.5 Volt, in
//! this situation the RFM7x gets 3.7 Volt. That is slightly high, but
//! probably not a big problem.
//! When the RFM7x draws its maximum current of 23 mA when the
//! microcontroller's power is at 4.5 Volt the RFM7x still gets 2.6 Volt.
//! You might want to double-check that the microcontroller accepts ~ 2 Volt
//! as a logic 1.
//!
//! TBW: picture
//!
//
//***************************************************************************//



#include "rfm7x_tm.h"


#include "rfm7x.h"


typedef unsigned char byte;

// RFM7x SPI read and write commands
#define RFM7x_CMD_READ_REG            0x00
#define RFM7x_CMD_WRITE_REG           0x20

//interrupt status
#define STATUS_RX_DR    0x40
#define STATUS_TX_DS    0x20
#define STATUS_MAX_RT   0x10

#define STATUS_TX_FULL  0x01

//FIFO_STATUS
#define FIFO_STATUS_TX_REUSE  0x40
#define FIFO_STATUS_TX_FULL   0x20
#define FIFO_STATUS_TX_EMPTY  0x10

#define FIFO_STATUS_RX_FULL   0x02
#define FIFO_STATUS_RX_EMPTY  0x01



// Bank0 register initialization values
#define BANK0_ENTRIES 10
const unsigned char Bank0_Reg[ BANK0_ENTRIES ][ 2 ]={
   {  0, 0x7F }, // receive, enabled, CRC 2, enable interupts
   {  1, 0x3F }, // auto-ack on all pipes enabled
   {  2, 0x03 }, // Enable pipes 0 and 1
   {  3, 0x03 }, // 5 bytes addresses
   {  4, 0b00010101 }, // auto retransmission (delay , count)
   {  5, 0x0A }, // channel 10
   {  6, 0b00000111 }, // data rate 1Mbit, power 5dbm, LNA gain high
   {  7, 0x07 }, // why write this at all?? but seems required to work...
   {  8, 0x00 }, // clear Tx packet counters
   { 23, 0x00 }, // fifo status
};

   // default receive address data pipe 0:
   // just a bunch of bytes, nothing magical
const unsigned char rfm7x_RX0_Address[5] = { 0x34, 0x43, 0x10, 0x10, 0x01 };


/*unsigned char rfm7x_SPI_RW( unsigned char value ){
   unsigned char i;
   for( i =0 ; i < 8; i++ ){
      RFM7x_WAIT_US( 1 );
      RFM7x_MOSI( value & 0x80  );
      value = (value << 1);    // shift next bit into MSB..

      RFM7x_WAIT_US( 1 );
      RFM7x_SCK( 1 );
      value |= RFM7x_MISO;     // capture current MISO bit

      RFM7x_WAIT_US( 1 );
      RFM7x_SCK( 0 );
      RFM7x_WAIT_US( 1 );
  }
  return value;
}*/

void rfm7x_register_write( unsigned char reg, unsigned char value )
{
   if( reg < RFM7x_CMD_WRITE_REG ){
      reg |= RFM7x_CMD_WRITE_REG;
   }
   RFM7x_CSN( 0 );                // CSN low, init SPI transaction
   (void)rfm7x_SPI_RW( reg );    // select register
   (void)rfm7x_SPI_RW( value );  // ..and write value to it..
   RFM7x_CSN( 1 );                // CSN high again
}

unsigned char rfm7x_register_read( unsigned char reg ){
   unsigned char value;
   //if( reg < RFM7x_CMD_WRITE_REG ){
   //   reg |= RFM7x_CMD_READ_REG;
   //}
   RFM7x_CSN( 0 );               // CSN low, initialize SPI communication...
   (void)rfm7x_SPI_RW( reg );   // Select register to read from..
   value = rfm7x_SPI_RW( 0 );   // ..then read register value
   RFM7x_CSN( 1 );               // CSN high, terminate SPI communication
   return value;                 // return register value
}

void rfm7x_buffer_read(  unsigned char reg,  unsigned char *pBuf, unsigned char length ){
   unsigned char i;
   //if( reg < RFM7x_CMD_WRITE_REG ){
//      reg |= RFM7x_CMD_READ_REG;
//   }
   RFM7x_CSN( 0 );                   // Set CSN 0
   (void)rfm7x_SPI_RW( reg );       // Select register to write
   for( i = 0; i < length; i++ ){    // read all bytes
      *pBuf++ = rfm7x_SPI_RW( 0 );  // read one byte from RFM7x
   }
   RFM7x_CSN( 1 );                   // Set CSN high again
}

void rfm7x_buffer_write( unsigned char reg,  const unsigned char *pBuf,  unsigned char length  ){
   unsigned char i;
   if( reg < RFM7x_CMD_WRITE_REG ){
      reg |= RFM7x_CMD_WRITE_REG;
   }
   RFM7x_CSN( 0 );                     // Set CSN low, init SPI transaction
   (void)rfm7x_SPI_RW( reg );         // Select register to write tio write
   for( i = 0; i < length; i++ ){      // write all bytes in buffer(*pBuf)
      (void)rfm7x_SPI_RW( *pBuf++ );  // write one byte
   }
   RFM7x_CSN( 1 );                     // Set CSN high again
}

unsigned char st;
void rfm7x_bank( unsigned char b ){
   st = (unsigned char)( 0x80 & rfm7x_register_read( RFM7x_REG_STATUS ) );
   if(( st &&( b == 0 )) || (( st == 0 ) && b )){
      rfm7x_register_write( RFM7x_CMD_ACTIVATE, 0x53 );
   }
}

   // magic bank1 register initialization values

const unsigned long RFM70_Bank1_Reg0_13[] = {
   0xE2014B40,
   0x00004BC0,
   0x028CFCD0,
   0x41390099,
   0x0B869ED9,
   0xA67F0224,
   0x00000000,
   0x00000000,
   0x00000000,
   0x00000000,
   0x00000000,
   0x00000000,
   0x00127300,
   0x36B48000 };

const unsigned long RFM73_Bank1_Reg0_13[] = {
   0xE2014B40,
   0x00004BC0,
   0x028CFCD0,
   0x41390099,
   0x1B8296D9,
   0xA67F0224,
   0x00000000,
   0x00000000,
   0x00000000,
   0x00000000,
   0x00000000,
   0x00000000,
   0x00127300,
   0x46B48000 };

   // more magic bank1 register initialization values
const unsigned char Bank1_Reg14[] = {
   0x41, 0x20, 0x08, 0x04, 0x81, 0x20, 0xCF, 0xF7, 0xFE, 0xFF, 0xFF };

   // initialize bank1 like in the example code.
   // don't ask why, just do it
volatile byte module_type = RFM_UNKNOWN;

void rfm7x_init_bank1( void ){
   unsigned char i, j;
   unsigned char WriteArr[ 12 ];

   unsigned long * Bank1_Reg0_13 = (unsigned long *)RFM70_Bank1_Reg0_13; //default
   if(module_type == RFM73) Bank1_Reg0_13 = (unsigned long *)RFM73_Bank1_Reg0_13;

   rfm7x_bank( 1 );

   for( i = 0; i <= 8; i++ ){ //reverse!
      for( j = 0; j < 4; j++ ){
         WriteArr[ j ] = (unsigned char )( (Bank1_Reg0_13[i]>>(unsigned char)(8*j) )&0xff );
      }
      rfm7x_buffer_write( i,WriteArr, 4 );
   }

   for( i = 9; i <= 13; i++ ){
      for( j = 0; j < 4; j++ ){
         WriteArr[ j ]= (unsigned char )((Bank1_Reg0_13[i]>>(unsigned char)(8*(3-j)) )&0xff);
      }
      rfm7x_buffer_write( i, WriteArr, 4 );
   }

   rfm7x_buffer_write( 14, Bank1_Reg14, 11 );

   //toggle REG4<25,26>
   for(j=0;j<4;j++){
      WriteArr[ j ]= (unsigned char)((Bank1_Reg0_13[4]>>(unsigned char)(8*j))&0xff);
   }

   WriteArr[ 0 ] = (unsigned char )(WriteArr[ 0 ] | 0x06);
   rfm7x_buffer_write( 4, WriteArr, 4);

   WriteArr[ 0 ] = (unsigned char )(WriteArr[ 0 ] & 0xf9);
   rfm7x_buffer_write( 4, WriteArr,4);

   rfm7x_bank( 0 );
}


void rfm7x_clear_irq( void ) {
  unsigned char st1;
  st1 = rfm7x_register_read( RFM7x_REG_STATUS );
  rfm7x_register_write( RFM7x_REG_STATUS, st1 | 0b01110000 );
}

unsigned char rfm7x_is_present( void ){
  unsigned char st1, st2;
  st1 = rfm7x_register_read( RFM7x_REG_STATUS );
  rfm7x_register_write( RFM7x_CMD_ACTIVATE, 0x53 );
  st2 = rfm7x_register_read( RFM7x_REG_STATUS );
  rfm7x_register_write( RFM7x_CMD_ACTIVATE, 0x53 );
  return (unsigned char )(( st1 ^ st2 ) == 0x80);
}


volatile byte rfm7x_mode;

void rfm7x_mode_receive( void )
{
  unsigned char value;

  rfm7x_mode = RFM7x_MODE_RECEIVE;

  // flush receive queue
  rfm7x_register_write( RFM7x_CMD_FLUSH_RX, 0 );

  // clear interrupt status
  value = rfm7x_register_read( RFM7x_REG_STATUS );
  rfm7x_register_write( RFM7x_REG_STATUS ,value );

  // switch to receive mode
  RFM7x_CE( 0 );
  value = rfm7x_register_read( RFM7x_REG_CONFIG );
  value |= 0x01; // set RX bit
  value |= 0x02; // set PWR_UP bit
  rfm7x_register_write( RFM7x_REG_CONFIG, value );
  RFM7x_CE( 1 );
}


void rfm7x_mode_transmit( void ){
   unsigned char value;
   rfm7x_mode = RFM7x_MODE_TRANSMIT;

   // flush transmit queue
   rfm7x_register_write( RFM7x_CMD_FLUSH_TX, 0);

   // clear interrupt status
   value = rfm7x_register_read( RFM7x_REG_STATUS );
   rfm7x_register_write( RFM7x_REG_STATUS ,value );

   // switch to transmit mode
   RFM7x_CE( 0 );
   value = rfm7x_register_read( RFM7x_REG_CONFIG );
   value &= 0xFE; // clear RX bit
   value |= 0x02; // set PWR_UP bit
   rfm7x_register_write( RFM7x_REG_CONFIG, value );
   RFM7x_CE( 1 );
}

void rfm7x_mode_standby( void ){
   unsigned char value;
   RFM7x_CE( 0 );
   value = rfm7x_register_read( RFM7x_REG_CONFIG );
   value |= 0x02; // set PWR_UP bit
   rfm7x_register_write( RFM7x_REG_CONFIG, value );
}

void rfm7x_mode_powerdown( void ){
   unsigned char value;
   RFM7x_CE( 0 );
   value = rfm7x_register_read( RFM7x_REG_CONFIG );
   value &= 0xFD; // clear PWR_UP bit
   rfm7x_register_write( RFM7x_REG_CONFIG, value );
}

volatile byte rfm7x_current_channel;
void rfm7x_channel( unsigned char ch ){
  // MSB must be 0
  rfm7x_current_channel = ch;
  rfm7x_register_write( RFM7x_REG_RF_CH, (unsigned char )(ch & 0x7E) );
}

void rfm7x_air_data_rate( unsigned char rate ){
   unsigned char value;
   RFM7x_CE( 0 );
   value = rfm7x_register_read( RFM7x_REG_RF_SETUP );
   value &= 0xF7;
   if( rate > 1 ){
      value |= 0x08;
   }
   rfm7x_register_write( RFM7x_REG_RF_SETUP, value );
   RFM7x_CE( 1 );
}

void rfm7x_crc_length( unsigned char len ){
   unsigned char val;
   if( len > 2 ){
      len = 2;
   }
   val = rfm7x_register_read( RFM7x_REG_CONFIG );
   if( len == 0 ){
      val &= 0xF3;
      rfm7x_register_write( RFM7x_REG_EN_AA, 0 );
      rfm7x_register_write( RFM7x_REG_CONFIG, val );
   } else {
      rfm7x_register_write( RFM7x_REG_EN_AA, 0x3F );
      val &= 0xFB;
      if( val == 2 ){
         val |= 0x04;
      }
      rfm7x_register_write( RFM7x_REG_CONFIG, val );
   }
}

void rfm7x_address_length( unsigned char len ){
   if( len > 5 ){
      len = 5;
   }
   if( len < 3 ){
      len = 3;
   }
   rfm7x_register_write( RFM7x_REG_SETUP_AW, (unsigned char )(len - 2) );
}

unsigned char rfm7x_transmit_fifo_full( void ){
  unsigned char s;
  s = rfm7x_register_read( RFM7x_REG_FIFO_STATUS );
  return (unsigned char )( (unsigned char) (s & FIFO_STATUS_TX_FULL ) != 0);
}

unsigned char rfm7x_receive_fifo_empty( void ){
  unsigned char s;
  s = rfm7x_register_read( RFM7x_REG_FIFO_STATUS );
  return (unsigned char )(( s & FIFO_STATUS_RX_EMPTY ) != 0);
}

void rfm7x_receive_address_p0( const unsigned char address[ 5 ] ){
   rfm7x_buffer_write( RFM7x_REG_RX_ADDR_P0, address, 5 );
}

void rfm7x_receive_address_p1( const unsigned char address[ 5 ] ){
   rfm7x_buffer_write( RFM7x_REG_RX_ADDR_P1, address, 5 );
}

void rfm7x_receive_address_pn( unsigned char channel, unsigned char address ){
   rfm7x_register_write( (unsigned char )(RFM7x_REG_RX_ADDR_P0 + channel), address );
}

void rfm7x_transmit_address( const unsigned char *address ){
   rfm7x_buffer_write( RFM7x_REG_TX_ADDR, address, 5 );
}

unsigned char rfm7x_retransmit_count( void ){
   return rfm7x_register_read ((unsigned char ) (( RFM7x_REG_OBSERVE_TX ) & 0x0F));
}

unsigned char rfm7x_lost_packets_count( void ){
   return ( rfm7x_register_read( (unsigned char )((RFM7x_REG_OBSERVE_TX ) >> 4 ) & 0x0F));
}

void rfm7x_pipe_autoack( unsigned char pipe, unsigned char enabled ){
   unsigned char val = rfm7x_register_read( RFM7x_REG_EN_AA );
   if( pipe > 5 ){
      pipe = 5;
   }
   if( enabled ){
      val |= 1 << pipe;
   } else {
      val &= ~ ( 1 << pipe );
   }
   rfm7x_register_write( RFM7x_REG_EN_AA, val );
}

void rfm7x_pipe_enable( unsigned char pipe, unsigned char enabled ){
   unsigned char val = rfm7x_register_read( RFM7x_REG_EN_RXADDR );
   if( pipe > 5 ){
      pipe = 5;
   }
   if( enabled ){
      val |= 1 << pipe;
   } else {
      val &= ~ ( 1 << pipe );
   }
   rfm7x_register_write( RFM7x_REG_EN_RXADDR, val );
}

void rfm7x_lost_packets_reset( void ){
   unsigned char val = rfm7x_register_read( RFM7x_REG_RF_CH );
   rfm7x_register_write( RFM7x_REG_RF_CH, val );
}

void rfm7x_retransmit_delay_attempts( unsigned char d, unsigned char n ){
   rfm7x_register_write( RFM7x_REG_SETUP_RETR, (unsigned char )(( n & 0x0F ) | (( d & 0x0F ) << 4 )));
}

void rfm7x_lna_high( void ){
   unsigned char val = rfm7x_register_read( RFM7x_REG_RF_SETUP );
   val |= 0x01;
   rfm7x_register_write( RFM7x_REG_RF_SETUP, val );
}

void rfm7x_lna_low( void ){
   unsigned char val = rfm7x_register_read( RFM7x_REG_RF_SETUP );
   val &= 0xFE;
   rfm7x_register_write( RFM7x_REG_RF_SETUP, val );
}

void rfm7x_power( unsigned char level ){
  unsigned char val;
   if( level > 3 ){
       level = 3;
   }
   RFM7x_CE( 0 );
   val = rfm7x_register_read( RFM7x_REG_RF_SETUP );
   val &= 0x09;
   val |= 0x30;
   val |= ( level << 1 );
   rfm7x_register_write( RFM7x_REG_RF_SETUP, val );
   RFM7x_CE( 1 );
}

void rfm7x_channel_payload_size( unsigned char channel, unsigned char size ){
   unsigned char val;
   if( size > 32 ){
      size = 32;
   }
   val = rfm7x_register_read( RFM7x_REG_DYNPD );
   if( size == 0 ){
      val |= 1 << channel;
   } else {
      val &= ~ ( 1 << channel );
   }
   rfm7x_register_write( RFM7x_REG_DYNPD, val );
   rfm7x_register_write( (unsigned char)(RFM7x_REG_RX_PW_P0 + channel), size );
}

void rfm7x_transmit_message( const unsigned char *buf, unsigned char length ){
   if( length > 32 ){
      length = 32;
   }
   rfm7x_buffer_write( RFM7x_CMD_W_TX_PAYLOAD, buf, length );
}

void rfm7x_transmit_message_once(
   const unsigned char *buf,
   unsigned char length
){
   if( length > 32 ){
      length = 32;
   }
   rfm7x_buffer_write( RFM7x_CMD_W_TX_PAYLOAD_NOACK, buf, length );
}

unsigned char rfm7x_receive_next_pipe( void ){
   unsigned char status = rfm7x_register_read( RFM7x_REG_STATUS );
   return (unsigned char)(( status >> 1 ) & 0x07);
}

unsigned char rfm7x_receive_next_length( void ){
   return rfm7x_register_read( RFM7x_CMD_R_RX_PL_WID );
}

unsigned char rfm7x_receive( unsigned char * pipe, unsigned char *buf, unsigned char * length){
   unsigned char p = rfm7x_receive_next_pipe();
   if( p == 0x07 ){
      return 0;
   }
   *pipe = p;
   *length = rfm7x_receive_next_length();
   rfm7x_buffer_read( RFM7x_CMD_R_RX_PAYLOAD, buf, * length );
   return 1;
}



void rfm7x_init( unsigned char _module_type ){
   unsigned char i;

   module_type = _module_type;

   RFM7x_CE( 0 );
   RFM7x_CSN( 1 );

   // delay at least 50ms.
   // the example code says so, but why??
   RFM7x_WAIT_MS( 50 );

   // write array of default init settings
   rfm7x_bank( 0 );
   for( i = 0; i < BANK0_ENTRIES; i++ ){
     rfm7x_register_write( Bank0_Reg[ i ][0], Bank0_Reg[ i ][1] );
   }

   rfm7x_receive_address_p0( rfm7x_RX0_Address );
   rfm7x_receive_address_p1( rfm7x_RX0_Address );
   rfm7x_transmit_address( rfm7x_RX0_Address );

   // enable the extra features
   i = rfm7x_register_read(29);
   if( i == 0 ){ // only when the extra features are not yet activated!
      rfm7x_register_write( RFM7x_CMD_ACTIVATE, 0x73 );
   }

   // select dynamic payload length data pipe5\4\3\2\1\0
   rfm7x_register_write( 28, 0x3F );

   // select Dynamic Payload Length, Payload with ACK, W_TX_PAYLOAD_NOACK
   rfm7x_register_write( 29, 0x07 );

   // dynamic payload sizing on channels 0 and 1
   rfm7x_channel_payload_size( 0, 0 );
   rfm7x_channel_payload_size( 1, 0 );

   rfm7x_init_bank1();
   RFM7x_WAIT_MS( 50 );
   //rfm7x_mode_receive();
}
