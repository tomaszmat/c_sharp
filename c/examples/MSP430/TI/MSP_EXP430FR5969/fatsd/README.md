## Example Summary

Sample application to read and write data onto an SD Card (SPI interface).

## Peripherals Exercised

* `Board_LED0` - Indicates that the board was initialized within `main()`
* `Board_SDSPI0` - Connection to SD card

## Resources & Jumper Settings

>Please refer to the development board's specific __Settings and Resources__
section in the Getting Started Guide. For convenience, a short summary is also
shown below.

| Development board | Notes                                                  |
| ----------------- | ------                                                 |
| CC3200            | Requires an external SD Card boosterpack               |
| EK-TM4C123GXL     | ^                                                      |
| DK-TM4C129X       | It uses the onboard SD Card slot.                      |
| EK-TM4C1294XL     | Requires an external SD Card boosterpack               |
| EK-TM4C129EXL     | ^                                                      |
| MSP-EXP430F5529LP | Requires an external SD Card boosterpack               |
| MSP-EXP430FR5969  | ^                                                      |
| MSP-EXP430FR6989  | ^                                                      |
| MSP-EXP432P401R   | ^                                                      |
| MSP-EXP430FR5994  | It uses the onboard SD Card slot.                      |
| TMDXDOCK28M36     | It uses the onboard SD Card slot.                      |
| TMDXDOCKH52C1     | It uses the onboard SD Card slot. Connectivity Bank 22-25: B-C position (SD card slot)|

> Fields left blank have no specific settings for this example.
> For fields containing ^, see the above entry for details

## Example Usage

* Run the example. `Board_LED0` turns ON to indicate TI-RTOS driver initialization is complete.

* The example proceeds to read the SD card. If the *input.txt* file is not
found, the file is created on the SD card with the following text:
```
    "***********************************************************************\n"
    "0         1         2         3         4         5         6         7\n"
    "01234567890123456789012345678901234567890123456789012345678901234567890\n"
    "This is some text to be inserted into the inputfile if there isn't     \n"
    "already an existing file located on the SDCard.                        \n"
    "If an inputfile already exists, or if the file was already once        \n"
    "generated, then the inputfile will NOT be modified.                    \n"
    "***********************************************************************\n"
```

* The *input.txt* file is then read and it's contents are written to a
new file called *output.txt*. If the file already exists on the SD card,
it will be overwritten.

* The contents of the *output.txt* file are then written to the console.

## Application Design Details

* This application demonstrates how to use TI-RTOS's SD Card driver to read and
write data onto a SD Card using standard CIO runtime system calls
(`fopen`, `fread`, `fwrite`, etc...).

* This application uses `SysStd` instead of `SysMin`. This was done because
real-time was not a concern and the size of the internal `SysMin` had to
be large to hold the output. Please refer to the TI-RTOS User Guide's
__Generating printf Output__ section for a comparison of the different System
Support implementations.

This application uses one task:

The `fatSDTask` performs the following actions:

1. Creates and initializes the SDSPI driver object.

2. Open the *input.txt* file. If not found, create the file for reading and
writing. Write the default message to the file.

3. Open the *output.txt* file. Content will be overwritten if found.

4. Copy the contents of *input.txt* to *output.txt*.  Close both files
afterwards.

5. Open *output.txt*, read the file and print the contents to `System_printf`.

6. The *output.txt* file and SDSPI driver are closed and the example is
terminated.

## References
* For GNU and IAR users, please read the following website for details
  about enabling [semi-hosting](http://processors.wiki.ti.com/index.php/TI-RTOS_Examples_SemiHosting)
  in order to view console output.
