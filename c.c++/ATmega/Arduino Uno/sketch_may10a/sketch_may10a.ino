int dataPin = 8;
int latchPin = 7;
int clockPin = 6;
int analogPinUp = A0;
int analogPinDown = A1;
int analogPinStart = A2;
int numberToDisplay = 0;
int motor1 = 12;
int motor2 = 13;
int valStart = 0;
int valUp = 0;
int valDown = 0;
byte dec_digits[] = {0b11000000,0b11111001,0b10100100,0b10110000,0b10011001,0b10010010,0b10000011,0b11111000,0b10000000,0b10011000 };

void setup() {
  //ustawienie pinów jako wyjść (output) w celu sterowania rejestrem przesuwnym
  pinMode(latchPin, OUTPUT);
  pinMode(clockPin, OUTPUT);
  pinMode(dataPin, OUTPUT);
  pinMode(analogPinUp, INPUT);
  pinMode(analogPinDown, INPUT);
   pinMode(motor1, OUTPUT);
  pinMode(motor2, OUTPUT);
 // Serial.begin(9600);
}

void loop() {
     valUp = analogRead(analogPinUp);
     valDown = analogRead(analogPinDown);
     if( valUp > 900)
         {
          delay(200);
         numberToDisplay++;}
     if(valDown > 900)
        { delay(200);
        numberToDisplay--;}
     //Serial.write(numberToDisplay);
     valStart = analogRead(analogPinStart);
    if(valStart > 900)
     {
       delay(200);
        digitalWrite(motor1, HIGH);
        delay(10000);
        digitalWrite(motor1, LOW);
        for(int i = numberToDisplay; i> 0; i--)
            {
              numberToDisplay--;
              digitalWrite(latchPin, LOW);
              shiftOut(dataPin, clockPin, MSBFIRST, dec_digits[numberToDisplay]);
              digitalWrite(latchPin, HIGH);
              delay(998);  
            }
        digitalWrite(motor2, HIGH);
        delay(10000);
        digitalWrite(motor2, LOW);
            
        
     }
     
     // read the input pin
    digitalWrite(latchPin, LOW);
    shiftOut(dataPin, clockPin, MSBFIRST, dec_digits[numberToDisplay]);
    digitalWrite(latchPin, HIGH);
  
}


