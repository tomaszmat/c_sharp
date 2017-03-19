float temp;

void setup() {
  Serial.begin(9600);
};

void loop () {
  temp = analogRead(A1)*5/1024.0;
  temp = temp - 0.5;
  temp = temp / 0.01;
  Serial.println(temp);
  delay(500);
};
