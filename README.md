# Creation of a velocity based fighting game controller (Hardware Course Project)
Worked on by Darren Chung and Alexander Hamblin


Prototype fabrication:


Working prototype


Iterative CAD files: 
Below shows the iterative process of our Custom PCB along with the decisions we desided to take.

<img width="500" height="500" alt="image" src="https://github.com/user-attachments/assets/ff530254-54e2-485b-87ca-5b38ef527247" />

Starting with the Wowki electronic simulation, This proof of concept was rather messy and had all the inputs we deemed nesscary, allowing the user to visually see if their input was sucessful.However this setup would prove diffuclt to make moblie and easy to interact, thus we opted for more compact design in following iterativons 

<img width="500" height="500" alt="Screenshot 2026-04-07 114830" src="https://github.com/user-attachments/assets/9065809e-1476-43ff-ba4f-9125c08f1573" />

Moving on to the KiCad PCB we swapped out most of the parts, foucsed on making the controller compact, swapping the ariduno uno for a Xiao Nrf52840 sense, for its built in IMU, which freed up board space for 4 buttons, then when discussing with our peers, came up with the idea to use einternet port to connect our two boards. This made connecting the two sides remarkable easy, and with the ports avaible we added a buzzer and single led to give the user feedback, via tones and led. We also swapped to a PSP joystick to save on more space and played around with the position of the parts to use if there were more ergomonic positions. 

Pre Wiring  |  Post Wiring 
:-------------------------:|:-------------------------:
![Image1](https://github.com/user-attachments/assets/12c85e16-b63b-45ff-bbbf-fe2ef8877970)  | ![Image2](https://github.com/user-attachments/assets/f7f9ed3c-98f1-4643-9164-e3aca38bd55a) 

These next two images show the v2 setup and the first verison that were wired, placing the mircocontroller facing the side and the buttons placed in a column at the top. This seemed like a great to have them placed as the wiring lined up nicely and the buttons were placed in a way that was intuitive to the user, however this was proven incorrect when talking to our peers as the usb c cable would be placed where the users hand would be and making the buttons hard to use. As for the right controller the marco buttons were added to increase user convience allowing them to bypass advanced inputs and a reorgianization of the buzzer and led, to make electronic wiring easier. 

Final Verison|  Print verision left controller | Print verision right controller  
:-------------------------:|:-------------------------:|:-------------------------:
![Image3](https://github.com/user-attachments/assets/bf1725a1-084a-4068-bfc3-ac74528dee0e)  | ![Image4](https://github.com/user-attachments/assets/db957c95-8320-496a-99fc-6cf3c2e5c927) |  ![Image5](https://github.com/user-attachments/assets/8c3a4d44-f0d4-4ecb-9402-77655313f4d0)

These two showcase the final verison of the board, and the print ready verison for both with the pcb being placed on the top, and the buttons in a square formation to make comibation moves such as a super (medium or heavy input + special input) easier for the user, ie using one finger to press two buttons at once. We also added mounting holes on the boards to screw them in place and to be able to quickly replace them as needed. 

Interactive scene 

Project progression timeline 
<iframe src="https://www.preceden.com/timelines/1368923/embed/1f6bd9210be1ede58964d615d123c7da" width="100%" height="604" frameborder="0"><a href="https://www.preceden.com" target="_top">Preceden Timeline Maker</a></iframe>

User testing

Link to Video Presentation
