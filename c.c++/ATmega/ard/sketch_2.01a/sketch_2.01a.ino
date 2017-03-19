/*
*  LCM1602 & Arduino Uno
*  VCC - > 5 V
*  GND - GND
*  SCL -> A5
*  SDA -> A4
*/



#define volPin  A0;            // potencjometr podłączony do A0
#define curPin A2;  


int vol = 0;
int dataPin = 8;
int latchPin = 7;
int clockPin = 6;

double voltage = 0.0;
int cur = 0;
double current = 0.0;


void setup()  
{
  pinMode(vol, INPUT);  
  pinMode(cur, INPUT);
  
pinMode(latchPin, OUTPUT);
  pinMode(clockPin, OUTPUT);
  pinMode(dataPin, OUTPUT);
 Serial.begin(9600);
   
 
}

byte dec_digits[] = {0b10000000,0b01000000,0b00100000,0b00010000,0b00001000,0b00000100,0b00000010,0b00000001,0b10000001,0b00000011 ,0b10000011,0b00000110};
// 31 do 65535 Hz, na zmiane o jeden przypada zmiana o częstotliowść 63,5
void loop() 
{
  

   
   // for (int numberToDisplay = 0; numberToDisplay <8; numberToDisplay++) 
   // {
    // take the latchPin low so
    // the LEDs don't change while you're sending in bits:
    digitalWrite(latchPin, LOW);
    shiftOut(dataPin, clockPin, MSBFIRST, dec_digits[7]);
   
    digitalWrite(latchPin, HIGH);
      vol = analogRead(A0);
   voltage = vol*0.0210184;
  Serial.print("V");
   Serial.println(voltage);
   
   
   cur = analogRead(A2);
  current = 36.7*0.0048828125*cur/5 - 18.3;
  Serial.println("I");
  Serial.println(current);
  Serial.println("--");
    delay(3000);
    
      digitalWrite(latchPin, LOW);
    shiftOut(dataPin, clockPin, MSBFIRST, dec_digits[8]);
   
    digitalWrite(latchPin, HIGH);
      vol = analogRead(A0);
   voltage = vol*0.0210184;
  Serial.print("V");
   Serial.println(voltage);
     cur = analogRead(A2);
  current = 36.7*0.0048828125*cur/5 - 18.3;
  Serial.println("I");
  Serial.println(current);
  Serial.println("--");
    delay(3000);

digitalWrite(latchPin, LOW);
    shiftOut(dataPin, clockPin, MSBFIRST, dec_digits[9]);
   
    digitalWrite(latchPin, HIGH);
      vol = analogRead(A0);
   voltage = vol*0.0210184;
  Serial.print("V");
   Serial.println(voltage);
     cur = analogRead(A2);
  current = 36.7*0.0048828125*cur/5 - 18.3;
  Serial.println("I");
  Serial.println(current);
  Serial.println("--");
    delay(3000);
    
digitalWrite(latchPin, LOW);
    shiftOut(dataPin, clockPin, MSBFIRST, dec_digits[10]);
   
    digitalWrite(latchPin, HIGH);
      vol = analogRead(A0);
   voltage = vol*0.0210184;
  Serial.print("V");
   Serial.println(voltage);
     cur = analogRead(A2);
  current = 36.7*0.0048828125*cur/5 - 18.3;
  Serial.println("I");
  Serial.println(current);
  Serial.println("--");
    delay(3000);

digitalWrite(latchPin, LOW);
    shiftOut(dataPin, clockPin, MSBFIRST, dec_digits[11]);
   
    digitalWrite(latchPin, HIGH);
      vol = analogRead(A0);
   voltage = vol*0.0210184;
  Serial.print("V");
   Serial.println(voltage);
     cur = analogRead(A2);
  current = 36.7*0.0048828125*cur/5 - 18.3;
  Serial.println("I");
  Serial.println(current);
  Serial.println("--");
    delay(3000);

digitalWrite(latchPin, LOW);
    shiftOut(dataPin, clockPin, MSBFIRST, dec_digits[6]);
   
    digitalWrite(latchPin, HIGH);
      vol = analogRead(A0);
  voltage = vol*0.0210184;
  Serial.print("V");
   Serial.println(voltage);
     cur = analogRead(A2);
  current = 36.7*0.0048828125*cur/5 - 18.3;
  Serial.println("I");
  Serial.println(current);
  Serial.println("--");
    delay(3000);
    
 
   // }
}




