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

#define volPin  A0;            // potencjometr podłączony do A0
#define curPin A2;       // przycisk


int vol = 0;
int cur = 0;


void setup()  
{
  pinMode(vol, INPUT);  
  pinMode(cur, INPUT);
 
 
  Serial.begin(9600);
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
 lcd.print("U: ");
  vol = analogRead(A0);
  double voltage = vol*0.0146;
  lcd.print(voltage);
  lcd.print("V");
  Serial.print("V");
   Serial.println(voltage);
   
  lcd.setCursor(1,0);
  lcd.print("I: ");
  cur = analogRead(A2);
  double current = 36.7*0.0048828125*cur/5 - 18.3;
  lcd.print(current);
  lcd.print("A");
  Serial.println(current);
  Serial.println("--");
  delay(1000);
   
}




