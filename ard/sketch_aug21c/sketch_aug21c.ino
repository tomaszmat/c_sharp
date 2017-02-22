/*
*  LCM1602 & Arduino Uno
*  VCC - > 5 V
*  GND - GND
*  SCL -> A5
*  SDA -> A4
*/

#include <Wire.h>   // standardowa biblioteka Arduino
#include <LiquidCrystal_I2C.h> // dolaczenie pobranej biblioteki I2C dla LCD

LiquidCrystal_I2C lcd(0x27, 2, 1, 0, 4, 5, 6, 7, 3, POSITIVE);  // Ustawienie adresu ukladu na 0x27
#define analogPin  0            // potencjometr podłączony do A0
#define buttonPin  7         // przycisk
#define buzPin   12          // brzeczyk

int val = 0;   
boolean start = false;
 int freq = 0;
 int plus = 0;
 int minus = 0;
int time = 2000;


void setup()  
{
  pinMode(buzPin, OUTPUT);  // pin 13 jako wyjście
  pinMode(buttonPin, INPUT_PULLUP);    // pin 7 jako wejście
  pinMode(3, INPUT_PULLUP);
  pinMode(5, INPUT_PULLUP);
  pinMode(2, INPUT_PULLUP);
  attachInterrupt(0, add, LOW);
  
  lcd.begin(16,2);   // Inicjalizacja LCD 2x16
  
  lcd.backlight(); // zalaczenie podwietlenia 
 lcd.clear();
  delay(500);
   //Ustawienie kursora w pozycji 0,0 (drugi wiersz, pierwsza kolumna)
 
}
// 31 do 65535 Hz, na zmiane o jeden przypada zmiana o częstotliowść 63,5
void loop() 
{
  lcd.setCursor(0,0);
 lcd.print("Vol: ");
  int vol = analogRead(A1);
  double voltage = vol*0.0146;
  lcd.print(voltage);
  lcd.print("V");
  
 lcd.setCursor(0,1);
 lcd.print("Freq : ");
  val = analogRead(A0);
 
  freq = 35 + (val*20) + minus; 
   lcd.print(freq);
   lcd.print("Hz");
    if(digitalRead(5)==LOW)
   { delay(10);minus -= 5;}
    
    if(digitalRead(3)==LOW)
   {delay(10);minus += 5;
  freq += minus;}
  ;
 
    if(digitalRead(7)==LOW)
   {   lcd.clear();
   lcd.print("shot");
   tone(buzPin,freq);
   for(int j = 0; j <10; j++)
{
  int cur = analogRead(A2);
  lcd.setCursor(0,0);
 lcd.print("SHOT");
  double current = 12*cur*5/1024 - 30;
  lcd.setCursor(0,1);
 lcd.print("I:");
 lcd.print(current);
 delay(10);
}
   noTone(buzPin);}
   delay(1000);
  lcd.clear();
   
}



void add()
{
  lcd.clear();
  lcd.print("shot");
   tone(buzPin,freq);
   delay(2000);
   noTone(buzPin);
   
}
