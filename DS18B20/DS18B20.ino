#include <OneWire.h>
#include <DallasTemperature.h>

#define led 13
// Data wire is plugged into port 2 on the Arduino
#define ONE_WIRE_BUS 2

// Setup a oneWire instance to communicate with any OneWire devices (not just Maxim/Dallas temperature ICs)
OneWire oneWire(ONE_WIRE_BUS);
// Pass our oneWire reference to Dallas Temperature. 
DallasTemperature sensors(&oneWire);


void setup(){
  // put your setup code here, to run once:

  Serial.begin(9600);
  pinMode(led, OUTPUT);

  // Start up the library
  sensors.begin();

}

void loop(){
  // put your main code here, to run repeatedly:
 String dulieu = "";
nhay1:

 while(Serial.available()>0)
  {
    char a = Serial.read();
    dulieu += a;
    //char dulieu = Serial.read();
    delay(5);
  }

  dulieu.trim();

  while(dulieu == "TS")
  {
  // call sensors.requestTemperatures() to issue a global temperature 
  // request to all devices on the bus
  //Serial.print("Requesting temperatures...");
  sensors.requestTemperatures(); // Send the command to get temperatures
  //Serial.println("DONE");
  
  //Serial.print("Temperature for the device 1 (index 0) is: ");
  Serial.println(sensors.getTempCByIndex(0));
  delay(1000);

  goto nhay1;
  }



  if(dulieu == "ON13")
  {
    digitalWrite(led, HIGH);
  }
  if(dulieu == "OFF13")
  {
    digitalWrite(led, LOW);
  }


  
}
