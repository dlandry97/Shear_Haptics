# Shear Haptics
The two main portions of this project include the design the mechanical structure of the device, and the integration of the haptic feedback with a virtual environment.

## How to use
1. This project uses:
    a. Unity Hub with Unity Editor run on Windows
    b. Oculus Rift with Rift Touch controllers
    c. Arduino Uno and Adafruit motorshieldv2
    d. prototype assembled with 3d printed parts(stls in models repo), servo motors, shafts, bearings, and timing belt(Links to amazon pages to non printed materials at bottom).
2. You will first need to download the arduino code from the arduino folder of the repo, and use the arduino IDE to upload it to an 'arduino uno' with a 'adafruit shieldv2'
3. You will also need the devices 

## Design
My general goal for the design was to create a shear movment about the controller grip with minimal actuators and a comfortable form as a handheld device. To achieve the linear motion of the grips, I considered many actuation schemes such as; linear actuators, worm gears, gears, belt drives. I decided to use a timing belt system actuated by a single high torque servo motor. The belt driven system gives the advantage of displacing the motor location away from the handle while still achieving strong linear force through the grips. The timing belt attaches to a set of carts guided by steel shaft rails. These shafts would function as a skeletal structure of the device as well as guide the grips in a linear path up and down the device. The second prototype increases efficiency and confort by slimming down the size of the mechanism while increasing the size of the grips.

![prototypes](git_assets/Prototypes.gif)

## Actuation
The actuation of the device is provided by a single 35kg/cm servo motor controlled by an arduino uno microcontroller. The servo drives a timing belt that attaches to and drives the grips. Each grip is designed to have a -10mm to 10mm travel range. I mounted and tested othe motor types. Using a stepper motor provided a decent amount of speed to the grip movement, but did not provide nearly enough torque to create a haptic feel. A brushed DC motor was tested and proved that it could provide torque, but did not have a sufficient ammount of speed or control for rapid testing. I added a belt gear drive to the servo system in attempt to increase its speed but keep a decent amount of torque, but the servo would stall from resistance torque from the grip.

## Interfacing
I used Unity game enigne to create a VR demo environemnt to integrate with the device. I'm using serial communication to read and write signals from Unity to the arduino to sync up to impacts in VR to the haptic feedback of the controller. I use Unity to design a VR sword that I can track the velocity data and collision status to determine the type of collision and send the appropriate status flags to the arduino to actuate the motor in the controller.

![VR_Demo](git_assets/VR.gif)

### Material links
To assemble the devices, you will need the materials below or equivalent.

4mm Steel shafts: https://www.amazon.com/uxcell-Lathe-Round-Solid-Length/dp/B07KT3TT7P/ref=sr_1_4?crid=TE2I4RT5COW7&keywords=4mm+x+200mm+shafts&qid=1643050683&s=digital-text&sprefix=4mm+x+200mm+shafts%2Cdigital-text%2C54&sr=1-4

5mm shafts: https://www.amazon.com/uxcell-Stainless-Support-Fasten-Elements/dp/B07MB8QV7J/ref=sr_1_1_sspa?crid=3E134VF2WL5PE&keywords=5mm+shaft&qid=1642015198&sprefix=5mm+shaft%2Caps%2C168&sr=8-1-spons&psc=1&smid=A30WUG2ZDGM0XM&spLa=ZW5jcnlwdGVkUXVhbGlmaWVyPUExMFQ2Q1VFQ043UkFTJmVuY3J5cHRlZElkPUEwNjE2MTM4MUFRRUYzNUdSSERVViZlbmNyeXB0ZWRBZElkPUEwMjYwNzM3MkhCMVNCN01ZMUYwWiZ3aWRnZXROYW1lPXNwX2F0ZiZhY3Rpb249Y2xpY2tSZWRpcmVjdCZkb05vdExvZ0NsaWNrPXRydWU=

Timing belt: https://www.amazon.com/KeeYees-Timing-Tensioner-Torsion-Printer/dp/B07JKT5BZQ/ref=sr_1_3?crid=2K5OKOSZN5V9M&keywords=stepper+belt+drive&qid=1642014158&sprefix=stepper+belt+drive%2Caps%2C141&sr=8-3

Arduino: https://www.amazon.com/Arduino-A000066-ARDUINO-UNO-R3/dp/B008GRTSV6/ref=asc_df_B008GRTSV6/?tag=hyprod-20&linkCode=df0&hvadid=309751315916&hvpos=&hvnetw=g&hvrand=4902964230044321845&hvpone=&hvptwo=&hvqmt=&hvdev=c&hvdvcmdl=&hvlocint=&hvlocphy=9021564&hvtargid=pla-457497319401&psc=1&tag=&ref=&adgrpid=67183599252&hvpone=&hvptwo=&hvadid=309751315916&hvpos=&hvnetw=g&hvrand=4902964230044321845&hvqmt=&hvdev=c&hvdvcmdl=&hvlocint=&hvlocphy=9021564&hvtargid=pla-457497319401

motor shield: https://www.amazon.com/Adafruit-Motor-Stepper-Shield-Arduino/dp/B00PUTH3B0/ref=sr_1_2?keywords=adafruit+shield&qid=1647371895&s=electronics&sprefix=adafruit+shile%2Celectronics%2C73&sr=1-2

servo shaft connector: https://www.amazon.com/Seamuing-Aluminum-Futaba-Mechanical-Helicopter/dp/B07D56FVK5/ref=sr_1_3?crid=25PI5DPJDGHJ9&keywords=25+tooth+servo+horn+adapter&qid=1642014624&sprefix=25+tooth+servo+horn+adapte%2Caps%2C126&sr=8-3

5mm shaft connector: https://www.amazon.com/Coupling-Connector-Coupler-Accessory-Fittings/dp/B08334MFVT/ref=sr_1_9?crid=3E134VF2WL5PE&keywords=5mm+shaft&qid=1642015198&sprefix=5mm+shaft%2Caps%2C168&sr=8-9

5mm bearings: https://www.amazon.com/F695-2RS-Bearing-5x13x4mm-Miniature-Bearings/dp/B07VMJLXLH/ref=pd_bxgy_img_2/144-8206906-2923141?pd_rd_w=LuFUz&pf_rd_p=c64372fa-c41c-422e-990d-9e034f73989b&pf_rd_r=QJF2DBMXSM558W1CF23X&pd_rd_r=049563f4-d605-4ee3-a4f3-ea5bafc20cfa&pd_rd_wg=mOE9f&pd_rd_i=B07VMJLXLH&psc=1

Heat Inserts: https://www.amazon.com/F695-2RS-Bearing-5x13x4mm-Miniature-Bearings/dp/B07VMJLXLH/ref=pd_bxgy_img_2/144-8206906-2923141?pd_rd_w=LuFUz&pf_rd_p=c64372fa-c41c-422e-990d-9e034f73989b&pf_rd_r=QJF2DBMXSM558W1CF23X&pd_rd_r=049563f4-d605-4ee3-a4f3-ea5bafc20cfa&pd_rd_wg=mOE9f&pd_rd_i=B07VMJLXLH&psc=1

Servo Motor: https://www.amazon.com/ZOSKAY-Coreless-Digital-Stainless-arduino/dp/B07S9XZYN2/ref=sr_1_15?crid=1DRAOEEM2M0A2&keywords=servo%2Bshaft&qid=1642014219&sprefix=servo%2Bshaft%2Caps%2C124&sr=8-15&th=1
