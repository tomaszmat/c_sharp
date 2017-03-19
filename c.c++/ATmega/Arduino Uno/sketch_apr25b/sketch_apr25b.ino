int pin_przycisk = A1;
int pin_dioda = A4;
 
void setup() {
  //ustawienia dla pinu przycisku
  pinMode(pin_przycisk, INPUT);     //pracuje jako wejscie
  digitalWrite(pin_przycisk, HIGH); //spoczynkowy stan wysoki (rezystory podciagajace wlaczone)
 
  //pin zapalajacy diode musi pracowac jako wyjscie
  pinMode(pin_dioda, OUTPUT);
  digitalWrite(pin_dioda, LOW);
  Serial.begin(9600);
}
 
void loop() {
  int przycisk = digitalRead(pin_przycisk); //odczytujemy stan przycisku
  if(przycisk == HIGH) 
  {           //
    digitalWrite(pin_dioda, LOW);
     //dioda ma byc zgaszona
     
  }
  else                             //w przeciwnym wypadku
  {
    digitalWrite(pin_dioda, HIGH); //dioda ma sie swiecic
     Serial.print("ddd");
  }
  delay(10);
}
