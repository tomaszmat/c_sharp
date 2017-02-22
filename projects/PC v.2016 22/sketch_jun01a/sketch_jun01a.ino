#include <Servo.h>

int Motor = A0;  
int przyciskStart = A1; 
int przyciskStop = A2;	

int Trig = 2;  
int Echo = 3; 

int ledStart = 7; 
int ledServo = 8; 
int servo = 9;	

Servo Selector; 

String inputString = "";	
char inChar; 			

  
int servoPosition = 0;		
boolean ifMotor = false;

					

boolean czyStart = false;	

int valStart = 0;	
int valStop = 0;	

float distance;
float objectHigh;
int selectingVal = 0; 
float rightDistance = 0;
float lastGood = 0;
float lastDis =0;
float high = 0;
boolean firstRun = true;
   
void setup()
{
  Serial.begin(9600);						
  Selector.attach(servo);					
  pinMode(Trig, OUTPUT);                     
  pinMode(Echo, INPUT);                      
  pinMode(Motor, OUTPUT); 					
  pinMode(przyciskStop, INPUT);
  pinMode(przyciskStart, INPUT);                    
  pinMode(ledServo, OUTPUT);                      
  pinMode(ledStart, OUTPUT); 
  pinMode(przyciskStop, OUTPUT);
  digitalWrite(ledStart, HIGH); 			
  Selector.write(0); 
}
  
void loop()
{
	warCal();
	readButtons();
	if(czyStart == true)
        {
                digitalWrite(ledStart, LOW);
                motorStart();
                lastDis = measure();
        	rightDistance = calc(lastDis);
        	objectHigh =  high - rightDistance ;
        	Serial.println(objectHigh);	
        	Serial.println(lastDis);
        	Serial.println(selectingVal);
                Serial.println(high);
                Serial.println("\n");
                if(selectingVal < objectHigh && selectingVal != 0 )  
        	{
              	    digitalWrite(Motor, LOW);
              	    doServo();
        	}
        }
        else  
        {
	        digitalWrite(ledStart, HIGH);
                digitalWrite(Motor, LOW);
        }
        		
}
  
void serialEvent() 
{
                while (Serial.available())
            	{
		inputString = "";				
		inChar = (char)Serial.read();	
		inputString += inChar;			
	        }
		int x = 0;						
		x = inputString.toInt();
                if( x == 8)
                    czyStart = true;
                else if( x == 9)
                    czyStart = false;
                else if( x == 7)
                {
                    digitalWrite(Motor, LOW);
                    doServo();
                }
                else if( x == 6)
                    restartCal();
                else
                {
                    digitalWrite(Motor, LOW); 			
		    doServo(); 	
                    selectingVal = x;
                    delay(1500);
                    motorStart();	
                }							
}

float measure()
{
        digitalWrite(Trig, LOW);
        delayMicroseconds(2);
        digitalWrite(Trig, HIGH);
        delayMicroseconds(10);
        digitalWrite(Trig, LOW);
        distance = pulseIn(Echo, HIGH);
        distance = distance/58;
        return distance;
}

float calc(float dst)
{ int dstt = dst;
	if( dstt > 2.0 && dstt <18.0)
	return dstt;
	else
	return 14;
}

void doServo()
{
      digitalWrite(ledServo, HIGH);
      for(servoPosition = 0; servoPosition < 70; servoPosition += 1) 
      {                                 
        Selector.write(servoPosition);              
        delay(2);                       
      }
      for(servoPosition = 70; servoPosition>=1; servoPosition-=1)     
      {
        Selector.write(servoPosition);              
        delay(2);                      
      }
      digitalWrite(ledServo, LOW);
}

void motorStart()
{
      analogWrite(Motor, 130); 
      delay(20);
      analogWrite(Motor, 105);
}

void readButtons()
{
      valStart = analogRead(A1); 
      if( valStart > 800)
      {
        delay(50);
        czyStart = true;
      }
      valStop = analogRead(A2); 
      if(valStop > 800)
      {
        czyStart = false;
        delay(50);
      }
}

float calibrate()
{ 
	float tempSum = 0;
	float tempSumDis = 0;
	for(int i = 0; i < 5; i++)
	{
	    tempSum += calc(measure());
	}
	tempSum = tempSum/5;
	if (tempSum < 13)
	{
            return 0;
        }
	else
	    return tempSum;
}

void warCal()
{
        if(firstRun == true)
        { 
          high = calibrate();
          firstRun = false;
        }
}

void restartCal()
{
        czyStart = false;
        firstRun = true;
        analogWrite(Motor,LOW);
        doServo();
        warCal();
}


