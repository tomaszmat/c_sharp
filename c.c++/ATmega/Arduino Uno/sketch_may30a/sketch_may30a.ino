#include <Servo.h>

int Motor = A0;  		//PIN A0 Arduino połączony z bramka tranzystora NPN

int Trig = 2;  //pin 2 Arduino połączony z pinem Trigger czujnika
int Echo = 12;  //pin 3 Arduino połączony z pinem Echo czujnika

int ledStart = 7; //Dioda LED zielona, świeci, gdy taśma jest gotowa do startu. Po wciśnięciu gaśnie.
int ledServo = 8; //Dioda LED czerwona, świeci gdy nastąpij detekcja obiektu niespelniającego warunków tj. świeci tylko wtedy gdy serwo działa.
int servo = 9;	//Serwonapęd podłączony jest do portu 9.

Servo Selector; //Tworzy obiekt Selector klasy Servo, max 8 obiektow można stworzyc tej klasy. Wykorzystujemy tutaj biblioteke dołączoną na początku <Servo.h>.

int przyciskStart = A1; //Przycisk Start.
int przyciskStop = A2;	//Przycisk Stop.

boolean czyStart = false;	//Flaga startu. Jeśli == false to nie wystartuje.

int valStart = 0;	// Tutaj przypisujemy wartość wciśnięcia w funkcji "readButtons()"
int valStop = 0;	//		--||--

  
int servoPosition = 0;		//Domyślna pozycja serwa to 0.

float distance;
float objectHigh;
int selectingVal = 3; 


   
void setup()
{//Inicjalizaja WE i WY.
  Serial.begin(9600);						//Inicjalizaja portu szeregowego. Domyślnie 8 bitów, brak parzystości, jeden bit stopu.
  Selector.attach(servo);					//Ustawienie PINu Serwa (9).
  pinMode(Trig, OUTPUT);                     // 2 - wyjście zbocza narastającego.
  pinMode(Echo, INPUT);                      //	3 - wejście odpowiedzi czujnika ultradźwiękowego.
  pinMode(Motor, OUTPUT); 					// A0 - wyjście sterujące tranzystorem NPN.         
  pinMode(ledServo, OUTPUT);                      
  pinMode(ledStart, OUTPUT); 
  pinMode(przyciskStop, INPUT);
  pinMode(przyciskStart, INPUT);  
  digitalWrite(ledStart, HIGH); 			//Po udanej inicjalizacji następuje włączenie zielonej diody LED.
}
  
void loop()
{
        readButtons();
	if(czyStart == true)
        {
              digitalWrite(ledStart, LOW);
              analogWrite(Motor, 130); 
              measure();
              objectHigh = 14.5 - distance;
              Serial.println(distance);		
              if( objectHigh  >4)
              {
               digitalWrite(Motor,LOW);
               Serial.println(objectHigh);
               doServo();
               delay(200);
              }
        }
        else  
        {
	//Flaga czyStart == false, zatem dioda gotowości do startu się pali. Silnik wyłączony.
	digitalWrite(ledStart, HIGH);
        digitalWrite(Motor, LOW);
        } 
}
  


void measure()
{
  digitalWrite(Trig, LOW);
  delayMicroseconds(2);
  digitalWrite(Trig, HIGH);
  delayMicroseconds(10);
  digitalWrite(Trig, LOW);
  distance = pulseIn(Echo, HIGH);
  distance = distance/58;
}

void doServo()
{
  digitalWrite(ledServo, HIGH);
  for(servoPosition = 0; servoPosition < 55; servoPosition += 1) 
  {                                 
    Selector.write(servoPosition);              
    delay(15);                       
  }
  for(servoPosition = 55; servoPosition>=1; servoPosition-=1)     
  {
    Selector.write(servoPosition);              
    delay(15);                      
  }
  digitalWrite(ledServo, LOW);
}


void readButtons()
{//W ciele tej funkcji następuje zmiana flagi "czyStart".
  valStart = analogRead(A1); 
  /*
  Sprawdź wartośc napięcia na PIN A1. 5V/1024 - daje nam dużą rozdzielczość.
  Przy zastosowanych przyciskach niestety istnieje możliwośc niedokładnego odczytu,
  dlatego obniżono próg detekcji wciśniecia przycisku.
  */
  if( valStart > 800)
  {
    delay(200);
    czyStart = true;
  }
  valStop = analogRead(A2); //Analogicznie jak wyżej.
  if(valStop > 800)
  {
    czyStart = false;
    delay(200);
  }
}

void motorStart()
{
  analogWrite(Motor, 130);
  delay(50);
  analogWrite(Motor, 50);
}



