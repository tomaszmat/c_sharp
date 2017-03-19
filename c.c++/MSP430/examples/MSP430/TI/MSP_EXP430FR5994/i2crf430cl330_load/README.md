## Example Summary

Sample application to read CPU load using a RF430CL330H I2C NFC transponder.

## Peripherals Exercised

* `Board_LED0` - Indicator LED
* `Board_LED1` - Indicator LED
* `Board_LED2` - Indicator LED
* `Board_I2C_NFC` - I2C used to communicate with RF430CL330H NFC transponder*.

## Resources & Jumper Settings

>Please refer to the development board's specific __Settings and Resources__
section in the Getting Started Guide. For convenience, a short summary is also
shown below.

| Development board | Notes                                                  |
| ----------------- | ------                                                 |
| DK-TM4C129X       |                                                        |
| EK-TM4C123GXL     |                                                        |
| EK-TM4C1294XL     |                                                        |
| EK-TM4C129EXL     |                                                        |
| MSP-EXP430F5529LP |                                                        |
| MSP-EXP430FR5969  |                                                        |
| MSP-EXP430FR6989  |                                                        |
| MSP-EXP430FR5994  |                                                        |
| MSP-EXP432P401R   |                                                        |

> Fields left blank have no specific settings for this example.

> This example was designed to use the DLP-RF430BP
Booster Pack (which contains the RF430CL330H).
The booster pack is required to successfully complete
this example.

> A NFC transceiver (such as a NFC enabled smart-phone)
is required to recover CPU load data.


## Example Usage

* Connect the DLP-RF430BP Booster Pack before powering the hardware.

* Run the example. `Board_LED0` turns ON to indicate TI-RTOS driver
initialization is complete.

* Once initialized, `Board_LED0` will be turned OFF. From this point onward
`Board_LED0`, `Board_LED1`, and `Board_LED2` will blink randomly
to show example is executing. When a LED is toggled, a message
is printed to the internal SysMin buffer. These can be viewed
by stopping the target and opening in SysMin in ROV.

* Hold any (such as a NFC enabled phone) NFC transceiver directly above the
NFC transponder. The NFC transceiver will receive the following message:
__`CPU Load: x`__

* Where __x__ is the current host processor CPU load. The example
will periodically update the CPU load until the target is halted
and example is terminated.

## Application Design Details

This application uses four tasks:

`nfcLoadTask` - is used to update CPU load messages on the RF430CL330H device.
`dummyTask` - is used to randomly toggle the indicator LEDs `Board_LED0`,
`Board_LED1`, and `Board_LED2`. This function is executed in three
statically created tasks (one for each LED).

`'nfcLoadTask'` performs the following actions:

1. Opens and initializes an I2C driver object.

2. Uses the I2C driver to reset and initialize the RF430CL330H device.

3. The task then clears the RF430CL330H control register to disable RF
communication.

4. The message to be transmitted is composed using `System_sprintf`. The CPU
load is provided by the SYS/BIOS Load module.

5. The I2C driver is used to write the message to the NFC transponder.

6. `nfcLoadTask` sleeps for 1000 system ticks before executing again and
 updating the CPU load message.


`'dummyTask'` performs the following actions:

1. LED index is provided in `arg0`. The index is used to access a single entry
in the `dummyCfg` array.

2. Sleeps for a randomly determined amount of system ticks. The value is
limited by the ticks member of the DUMMYTASKCFG structure.

3. The LED is toggled. A message with the Task sleep and count is printed
to `System_printf`.


## References
* For GNU and IAR users, please read the following website for details
  about enabling [semi-hosting](http://processors.wiki.ti.com/index.php/TI-RTOS_Examples_SemiHosting)
  in order to view console output.
