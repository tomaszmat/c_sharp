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
tone(buzPin,freq);
   
   
}


void add()
{
 
   tone(buzPin,freq);
   
   
   
}
