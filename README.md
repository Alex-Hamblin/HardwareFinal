# Creation of a velocity-based fighting game controller (Hardware Course Project)
Worked on by Darren Chung and Alexander Hamblin


**Prototype fabrication**:

https://github.com/user-attachments/assets/f72a237f-5740-47ca-832d-5cea9c345368

This used 2hrs 30 minutes and was using Pla plastic from the lab. 


**Working prototype**:


**Iterative CAD files**: 

KiCad iterative process and files in FinalDesignFinal folder
https://github.com/user-attachments/assets/cfbbe8fc-cdd5-4a8e-aa55-ea8385bb9235



Controller exploded view
[FInalControllerExplodedView.pdf](https://github.com/user-attachments/files/26558562/FInalControllerExplodedView.pdf)


Controller bill of materials 
[FInalControllerBOM.xlsx](https://github.com/user-attachments/files/26558554/FInalControllerBOM.xlsx)

Exploded view animation 
https://github.com/user-attachments/assets/b0dd7bd0-395a-45b4-9529-d3fd8e0371a2





**Interactive scene** 
https://github.com/user-attachments/assets/4f0b3efb-faf3-41ea-97ac-a124988e32a7


**Project progression timeline** 

**Timeline:**
<img width="2544" height="524" alt="image" src="https://github.com/user-attachments/assets/bd684bce-cb05-47c0-bf61-160622ba65be" /> 
<img width="5020" height="816" alt="timelinep2" src="https://github.com/user-attachments/assets/285c1a4d-e3fa-4978-aec2-ebe7c486d3c4" />

Links to Timeline:

part1:
https://www.preceden.com/timelines/1368923/e80afaeac3a54e3d

part 2:
https://www.preceden.com/timelines/1369024-timelinep2/f8a0170a067dd917


Below shows the iterative process of our Custom PCB along with the decisions we decided to take.

<img width="500" height="500" alt="image" src="https://github.com/user-attachments/assets/ff530254-54e2-485b-87ca-5b38ef527247" />

Starting with the Wowki electronic simulation, this proof of concept was rather messy and had all the inputs we deemed necessary, allowing the user to visually see if their input was successful. However, this setup would prove difficult to make mobile and easy to interact, thus we opted for more compact design in following iterations 

<img width="500" height="500" alt="Screenshot 2026-04-07 114830" src="https://github.com/user-attachments/assets/9065809e-1476-43ff-ba4f-9125c08f1573" />

Moving on to the KiCad PCB we swapped out most of the parts, focused on making the controller compact, swapping the Arduino uno for a Xiao Nrf52840 sense, for its built in IMU, which freed up board space for 4 buttons, then when discussing with our peers, came up with the idea to use Ethernet port to connect our two boards. This made connecting the two sides remarkable easy, and with the ports available we added a buzzer and single led to give the user feedback, via tones and led. We also swapped to a PSP joystick to save on more space and played around with the position of the parts to use if there were more ergonomic positions. 

Pre Wiring  |  Post Wiring 
:-------------------------:|:-------------------------:
![Image1](https://github.com/user-attachments/assets/12c85e16-b63b-45ff-bbbf-fe2ef8877970)  | ![Image2](https://github.com/user-attachments/assets/f7f9ed3c-98f1-4643-9164-e3aca38bd55a) 

These next two images show the v2 setup and the first version that were wired, placing the microcontroller facing the side and the buttons placed in a column at the top. This seemed like a great to have them placed as the wiring lined up nicely and the buttons were placed in a way that was intuitive to the user, however this was proven incorrect when talking to our peers as the USB c cable would be placed where the users hand would be and making the buttons hard to use. As for the right controller the Marco buttons were added to increase user convivence allowing them to bypass advanced inputs and a reorganization of the buzzer and led, to make electronic wiring easier. 

Final Version | Print version left controller | Print version right controller  
:-------------------------:|:-------------------------:|:-------------------------:
![Image3](https://github.com/user-attachments/assets/bf1725a1-084a-4068-bfc3-ac74528dee0e)  | ![Image4](https://github.com/user-attachments/assets/db957c95-8320-496a-99fc-6cf3c2e5c927) |  ![Image5](https://github.com/user-attachments/assets/8c3a4d44-f0d4-4ecb-9402-77655313f4d0)

These two showcase the final version of the board, and the print ready version for both with the PCB being placed on the top, and the buttons in a square formation to make combination moves such as a super (medium or heavy input + special input) easier for the user, i.e. using one finger to press two buttons at once. We also added mounting holes on the boards to screw them in place and to be able to quickly replace them as needed. 


After this We iterated off the controller models to create our final designs. 

**User testing**
We were unable to perform user testing due to our board bridging ground and 3Vs and because the game lab wasn't open yesterday for sign outs 

**Link to Video Presentation**
https://youtu.be/sh5r1HefOLY

**Report**
[The development of a velocity-based fighting game controller.pdf](https://github.com/user-attachments/files/26560587/The.development.of.a.velocity.based.fighting.game.controller.pdf)

