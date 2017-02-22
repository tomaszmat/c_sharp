## Example Summary

This application demonstrates how to use the TI-RTOS Watchdog driver to call a
function on expiration of the watchdog timer.

## Peripherals Exercised

* `Board_LED0`      - Indicator LED
* `Board_BUTTON0`   - Used to control the application
* `Board_WATCHDOG0` - Timer to trigger the watchdog interrupt service routine

## Resources & Jumper Settings

> Please refer to the development board's specific __Settings and Resources__
> section in the Getting Started Guide. For convenience, a short summary is also
> shown below.

|Development board |   Notes |
|------------------| --------|
| DK-TM4C123G      |  |
| DK-TM4C129X      |  |
| EK-TM4C123GXL    |  |
| EK-TM4C1294XL    |  |
| EK-TM4C129EXL    |  |
| MSP-EXP430F5529LP| Close Jumpers J2 and J3  |
| MSP-EXP430FR5969 |  |
| MSP-EXP430FR6989 |  |
| MSP-EXP430FR5994 |  |
| MSP-EXP432P401R  |  |
| TMDXDOCK28M36    |  |
| TMDXDOCKH52C1    |  |

> Fields left blank have no specific settings for this example.

## Example Usage

* The application turns ON `Board_LED0` to indicate TI-RTOS driver
initialization is complete.

* `Board_LED0` is toggled repeatedly until `Board_BUTTON0` is pressed. A flag is
toggled once `Board_BUTTON0` is pushed. Once this occurs, the watchdog timer will
be continuously cleared and `Board_LED0` will stay lit.

## Application Design Details

* The application's `main()` function opens a Watchdog driver object. The
`watchdog` task toggles a flag depending on whether `Board_BUTTON0` has been
pushed. If the flag is set, the task will continously call `Watchdog_clear()`
and set `Board_LED0`. If the flag is not set, then the timer will expire and
trigger an interrupt to toggle `Board_LED0`.

## References

* For GNU and IAR users, please read the following website for details
  about enabling [semi-hosting](http://processors.wiki.ti.com/index.php/TI-RTOS_Examples_SemiHosting)
  in order to view console output.
