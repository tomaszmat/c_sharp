#define analogPin  0            // potencjometr podłączony do A0
int val = 0;                     // zmienna przechowująca odczytaną wartość
 
void setup()
{
  Serial.begin(9600);            // inicjalizacja portu szeregowego
}
 
void loop()
{
  val = analogRead(analogPin);   // odczyt wartości napięcia z portu A0
  Serial.println(val);           // wysłanie odczytanej wartości na terminal
}
