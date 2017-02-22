## Example Summary

Sample application to connect to a USB host as a mouse HID device.

## Peripherals Exercised

* `Board_LED0` - Indicator LED
* `Board_BUTTON0` - Used to simulate a primary mouse button
* `Board_USBDEVICE`- Used as HID Mouse device

## Resources & Jumper Settings

>Please refer to the development board's specific __Settings and Resources__
section in the Getting Started Guide. For convenience, a short summary is also
shown below.

| Development board | Notes                                                  |
| ----------------- |------                                                  |
| DK-TM4C129X       | Please ensure that the board is connected to your host via a USB cable. A VCOM (virtual COM) port driver may need to be installed.      |
| EK-TM4C123GXL     | ^                                                       |
| EK-TM4C1294XL     | ^                                                       |
| EK-TM4C129EXL     | ^                                                       |
| MSP-EXP430F5529LP | ^                                                       |
| TMDXDOCK28M36     | ^                                                       |
| TMDXDOCKH52C1     | Please ensure that the board is connected to your host via a USB cable. A VCOM (virtual COM) port driver may need to be installed. Connectivity Bank 30-31: B-C position (USB)|

> Fields left blank have no specific settings for this example.
> For fields containing ^, refer to the above settings.

## Example Usage

* Run the example. `Board_LED0` turns ON to indicate TI-RTOS driver
initialization is complete.

* The example acts as a mouse to your host; it moves the cursor
in a figure eight pattern. Pressing `Board_BUTTON0` performs a primary click.


USB drivers can be found at the following locations:

1. Tiva USB Drivers:
Windows USB drivers are located in the products directory:
`<tirtos_install_dir>\products\<TivaWare_install_dir>\windows_drivers`

2. MSP430 USB Drivers:
Windows USB drivers are located within the CCS project's `USB_config/`
directory.

3. Concerto Family USB Drivers:
Windows USB drivers are located in the products directory:
`<tirtos_install_dir>\products\<MWare_install_dir>\windows_drivers`

> If the moving mouse gets annoying, you can suspend the target by hitting Alt-F8
in CCS.

## Application Design Details

This application uses one tasks:

`mouse` performs the following actions:

1. Waits for the device to connect to a USB host.

2. Once connected it sends predefined mouse offsets (from the
`mouseLookupTable[]`) along with primary click status.


## References

* For GNU and IAR users, please read the following website for details
  about enabling [semi-hosting](http://processors.wiki.ti.com/index.php/TI-RTOS_Examples_SemiHosting)
  in order to view console output.
