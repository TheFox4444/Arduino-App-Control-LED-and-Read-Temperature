Note: there's a Bao Cao Do Nhiet bang arduino.docx file that explains all the code, the environment needed, and the way to connect wire, written in Vietnamese
This is the app I made for my exam, and the Only Graph button still has bugs, I recommend to not clicking that before I'm done fixing it. To run the app properly, you must:
1. In the DS18B20 file contains an Arduino code file written by C++ which needs the Arduino app to run, with me, I use Arduino 1.8.19.
2. When you first open it, you must install four libraries which is:
  +DallasTemperature
  +MAX31850 DallasTemp
  +MAX31850 OneWire
  +OneWire
3. When you are done connecting wires, install libraries for the Arduino app, then choose the COMPort that connects with your Arduino board and upload your code into it.
4. Wait for the Arduino app done upload the code, close it, and then you can use my C# code to build the WinForm app or use the Arduino Tem Sensor.rar that contain the WinForm app to take control of the board.
