// Numer analogowego pinu do którego podłączony jest potencjometr
#define pote A0
int time = 0;
int valPote = 0;
void setup()
{
  // Ustawienie komunikacji z komputerem na 57600 bodów
  Serial.begin(9600);

  
}

void loop()
{
  valPote = analogRead(pote);
        if(valPote >= 0 && valPote <205)
        {
          time = 100;
        }
        else  if(valPote >204 && valPote <409)
        {
          time = 300;
        }
        else  if(valPote >408 && valPote < 614)
        {
          time = 500;
        }
        else  if(valPote > 613 && valPote < 818)
        {
          time = 800;
        }
        else  if(valPote > 817 && valPote < 1030)
        {
          time = 1000;
        }
        Serial.println(time);
        delay(1000);
}
