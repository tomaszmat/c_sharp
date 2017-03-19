int tran = 13;
int tran2 = 12;
int led2 = 2;
int led3 = 3;
int led4 = 4;
int led5 = 5;
int led6 = 6;
int led7 = 7;
int led8 = 8;



void setup() 
{
    pinMode( tran, OUTPUT);
    pinMode( tran2, OUTPUT);
    pinMode( led3, OUTPUT);
    pinMode( led2, OUTPUT);
    pinMode( led4, OUTPUT);
    pinMode( led5, OUTPUT);
    pinMode( led6, OUTPUT);
    pinMode( led7, OUTPUT);
    pinMode( led8, OUTPUT);
    
    //digitalWrite(led3, HIGH);
}

void loop() 
{
 // digitalWrite(led, LOW);
 // muli();
  digitalWrite(tran, HIGH);
  digitalWrite(tran2, HIGH);
  lefSeg();
 
  
}

void muli()
{
  digitalWrite(tran, HIGH);
  delay(1);
  digitalWrite(tran, LOW);
  delay(1);
  
}

void lefSeg()
{
  zgasWszystkie();
   lightZero();
   delay(1000);
   
   zgasWszystkie();
   lightOne();
   delay(1000);
   
   zgasWszystkie();
   lightTwo();
   delay(1000);
   
   zgasWszystkie();
   lightThree();
   delay(1000);
   
   zgasWszystkie();
   lightFour();
   delay(1000);
   
   zgasWszystkie();
   lightFive();
   delay(1000);
   
   zgasWszystkie();
   lightSix();
   delay(1000);
   
   zgasWszystkie();
   lightSeven();
   delay(1000);
   
    zgasWszystkie();
   lightEight();
   delay(1000);
   
    zgasWszystkie();
   lightNine();
   delay(1000);
}

void zgasWszystkie()
{
    digitalWrite(led2, HIGH);
    digitalWrite(led3, HIGH);
    digitalWrite(led4, HIGH);
    digitalWrite(led5, HIGH);
    digitalWrite(led6, HIGH);
    digitalWrite(led7, HIGH);
    digitalWrite(led8, HIGH);
}

void lightZero()
{
  digitalWrite(led3, LOW);
  digitalWrite(led4, LOW);
  digitalWrite(led5, LOW);
  digitalWrite(led6, LOW);
  digitalWrite(led8, LOW);
  digitalWrite(led7, LOW);
}

void lightOne()
{
   digitalWrite(led5, LOW);
  digitalWrite(led6, LOW);
}

void lightTwo()
{
   digitalWrite(led4, LOW);
  digitalWrite(led5, LOW);
  digitalWrite(led2, LOW);
  digitalWrite(led7, LOW);
  digitalWrite(led8, LOW);
}

void lightThree()
{
  digitalWrite(led4, LOW);
  digitalWrite(led5, LOW);
  digitalWrite(led2, LOW);
  digitalWrite(led6, LOW);
  digitalWrite(led8, LOW);
}

void lightFour()
{
  digitalWrite(led3, LOW);
  digitalWrite(led2, LOW);
  digitalWrite(led5, LOW);
  digitalWrite(led6, LOW);
}

void lightFive()
{
  digitalWrite(led3, LOW);
  digitalWrite(led2, LOW);
  digitalWrite(led4, LOW);
  digitalWrite(led6, LOW);
  digitalWrite(led8, LOW);
}

void lightSix()
{
  digitalWrite(led3, LOW);
  digitalWrite(led2, LOW);
  digitalWrite(led4, LOW);
  digitalWrite(led6, LOW);
  digitalWrite(led8, LOW);
  digitalWrite(led7, LOW);
}
void lightSeven()
{
  digitalWrite(led4, LOW);
  digitalWrite(led6, LOW);
  digitalWrite(led5, LOW);
}

void lightEight()
{
  digitalWrite(led2, LOW);
  digitalWrite(led3, LOW);
  digitalWrite(led4, LOW);
  digitalWrite(led5, LOW);
  digitalWrite(led6, LOW);
  digitalWrite(led8, LOW);
  digitalWrite(led7, LOW);
}

void lightNine()
{
  digitalWrite(led2, LOW);
  digitalWrite(led3, LOW);
  digitalWrite(led4, LOW);
  digitalWrite(led5, LOW);
  digitalWrite(led6, LOW);
  digitalWrite(led8, LOW);
}
