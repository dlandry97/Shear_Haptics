#include <AFMotor.h>

//
//void setup() {
//  // put your setup code here, to run once:
//
//}
//
//void loop() {
//  // put your main code here, to run repeatedly:
//
//}

#include <Servo.h>

Servo myservo;  // create servo object to control a servo
// twelve servo objects can be created on most boards

int pos = 0;    // variable to store the servo position
int del = 0;

void setup() {
  Serial.begin(9600);
  myservo.attach(10);  // attaches the servo on pin 9 to the servo object
}
void loop() {
//  Serial.print("\n in loop");
  del=700;
  myservo.write(90);
  delay(del);



  myservo.write(130);
  delay(del);
//
//  myservo.write(60);
//  delay(del);
//
//
//
//  myservo.write(35);
//  delay(del);
  
  
//  char msg;
//  pos = 0;
//  del=700;
////  myservo.write(60);
////  delay(del);
//  if(Serial.available()){
////    Serial.print("\n Serial is avail");
//    msg = Serial.read();
////    Serial.print(msg);
//  }
//  
//  
//  
//  if (msg == 'A'){
//    myservo.write(70);
////    Serial.print("\n geting 70");
//    delay(del);
//  }
//  if (msg == 'Z'){
//    myservo.write(90);
////    Serial.print("\n geting 50");
////    delay(del);
//  }
//  if (msg == 'B'){
//    myservo.write(60);
////    Serial.print("\n geting 60");
//    delay(del);
//  }
}
