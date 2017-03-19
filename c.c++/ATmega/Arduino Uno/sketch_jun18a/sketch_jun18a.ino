float temp;

void setup() {
  Serial.begin(9600);
};

void loop () {
 
  double temp = Thermister(analogRead(0));  // Read sensor;
 // double temp2 = 10*Thermister(analogRead(2));
  Serial.println(temp);
  //Serial.println(temp2);
  to92();
  delay(1000);
};

double Thermister(int RawADC) {
  double Temp;
  
  Temp = log(((10240000/RawADC) - 10000));
  Temp = 1 / (0.001129148 + (0.000234125 * Temp) + (0.0000000876741 * Temp * Temp * Temp));
  Temp = Temp - 273.15;           // Convert Kelvin to Celcius
  return Temp;
}

#define TempPin 0
#define Voltage 5

float temp;

void to92 () {
temp = analogRead(TempPin)*Voltage/1024.0;
temp = temp - 0.5;
temp = temp / 0.01;
Serial.println(temp);

};
