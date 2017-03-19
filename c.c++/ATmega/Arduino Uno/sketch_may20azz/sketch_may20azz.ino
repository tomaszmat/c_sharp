#include <Servo.h>

int Motor = A0;  		//PIN A0 Arduino połączony z bramka tranzystora NPN
int przyciskStart = A1; //Przycisk Start.
int przyciskStop = A2;	//Przycisk Stop.

int Trig = 2;  //pin 2 Arduino połączony z pinem Trigger czujnika
int Echo = 3;  //pin 3 Arduino połączony z pinem Echo czujnika

int ledStart = 7; //Dioda LED zielona, świeci, gdy taśma jest gotowa do startu. Po wciśnięciu gaśnie.
int ledServo = 8; //Dioda LED czerwona, świeci gdy nastąpij detekcja obiektu niespelniającego warunków tj. świeci tylko wtedy gdy serwo działa.
int servo = 9;	//Serwonapęd podłączony jest do portu 9.

Servo Selector; //Tworzy obiekt Selector klasy Servo, max 8 obiektow można stworzyc tej klasy. Wykorzystujemy tutaj biblioteke dołączoną na początku <Servo.h>.

String inputString = "";	//Tutaj będziemy przypisywać kolejno znaki wysłane z PC.
char inChar; 				//Tutaj przypisujemy pojedynczy znak odebrany z portu szeregowego.

  
int servoPosition = 0;		//Domyślna pozycja serwa to 0.


String start = "STR"; // Wykorzystane w zdarzeniu otrzymania znaku na port szeregowy.
String stop = "STP";	// 						--||--

boolean czyStart = false;	//Flaga startu. Jeśli == false to nie wystartuje.

int valStart = 0;	// Tutaj przypisujemy wartość wciśnięcia w funkcji "readButtons()"
int valStop = 0;	//		--||--

float distance;
float objectHigh;
int selectingVal = 0; 
/*
przyslamy wysokosc, ktora ma nie zostac zepchnieta z tasmy. 
Czyli np. wyślemy z programu 3cm to wszystkie inne z poza zakresu <2.5cm ; 3,5cm>
 mają zostać wywalone
 */

   
void setup()
{//Inicjalizaja WE i WY.
  Serial.begin(9600);						//Inicjalizaja portu szeregowego. Domyślnie 8 bitów, brak parzystości, jeden bit stopu.
  Selector.attach(servo);					//Ustawienie PINu Serwa (9).
  pinMode(Trig, OUTPUT);                     // 2 - wyjście zbocza narastającego.
  pinMode(Echo, INPUT);                      //	3 - wejście odpowiedzi czujnika ultradźwiękowego.
  pinMode(Motor, OUTPUT); 					// A0 - wyjście sterujące tranzystorem NPN.
  pinMode(przyciskStop, INPUT);
  pinMode(przyciskStart, INPUT);                    
  pinMode(ledServo, OUTPUT);                      
  pinMode(ledStart, OUTPUT); 
  pinMode(przyciskStop, OUTPUT);
  digitalWrite(ledStart, HIGH); 			//Po udanej inicjalizacji następuje włączenie zielonej diody LED.
}
  
void loop()
{//Główny program.
	readButtons();
	if(czyStart == true)
    {
	//Sprawdzenie, czy zostały spełnione warunki startu. Tj. Flaga musi być TRUE. Jeśli nie to dzieje się to co jest w ciele "else.
    digitalWrite(ledStart, LOW);
    motorStart();
    measure();
	objectHigh = 6.10 - distance;
			if((selectingVal+0.5) > objectHigh && objectHigh < (selectingVal-0.5)  )  
					{//tutaj sprawdzamy czy się mieści w przedziale np tym podanym wyżej <2.5cm;3.5cm>. Jeśli nie to wyrzut z taśmy.
					Serial.println(objectHigh);		//Wysłanie wysokości obiektu do PC.
					digitalWrite(Motor, LOW);		//Wyłączenie silnika.
					doServo();
					delay(100);
					}       
			}
    else  
    {
	//Flaga czyStart == false, zatem dioda gotowości do startu się pali. Silnik wyłączony.
	digitalWrite(ledStart, HIGH);
    digitalWrite(Motor, LOW);
    } 
}
  
void serialEvent() 
{//Odebranie z portu.
    while (Serial.available())//Jeśli port dostępny to... . Nie można odczytać w tym samym momencie, w którym coś wysyłamy.
	{
		inputString = "";				//Czyścimy zawrtość naszego ciągu wyrazów, aby nie przypisywał odebranych znaków z poprzedniego "serialEvent".
		inChar = (char)Serial.read();	//Chwilowy bufor znakowy.
		inputString += inChar;			//Składanie całości.
	}
	if(inputString != stop || inputString != start)
	{	/*
		Jeśli odebrany przez nas ciąg nie jest niczym co mogłoby zmienić flage "czyStart"
		to przypisujemy wartość liczbowa do wartości selektora. Zakładamy bezbłędnia komunikacje
		oraz to, że nie wyślemy innego ciągu znakowego
		*/
		digitalWrite(Motor, LOW); 				//Wyłączenie silnika
		doServo(); 								//Zepchnięcie, aby nic nie stało pod czujnikiem, gdy uruchomi się z nowa wartościa selekcjonowania.
		selectingVal = inputString.toInt();		//Przypisanie nowej wartości selekcjonowania.
		delay(1500);							//Poczekaj 1,5s.
		motorStart();							//Uruchomiene ponowne silnika. ->Automatyczny powrót do pętli 	"void loop()"
	}
	else
	{
		/*
		Analogicznie do tego co działo się wyżej.
		Tutaj jednak zachodzi zmiana flagi "czyStart"
		*/
		if(inputString == stop) czyStart = false; 
		else if (inputString == start) czyStart = true;
	}
          
}

void measure()
{//Pomiar.
  digitalWrite(Trig, LOW);
  delayMicroseconds(2);
  digitalWrite(Trig, HIGH);
  delayMicroseconds(10);
  digitalWrite(Trig, LOW);
  distance = pulseIn(Echo, HIGH);
  distance = distance/58;
}

void doServo()
{//Stały ustawiony obrót o 55stopni.
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

void motorStart()
{//Uruchomiene silnika.
  analogWrite(Motor, 130); //130 - PWM
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


