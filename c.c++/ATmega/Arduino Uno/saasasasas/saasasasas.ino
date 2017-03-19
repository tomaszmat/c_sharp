byte a=4,b=5,c=6,d=8,e=7,f=3,g=2;
int pause=10;
byte x1=12,x2=13;

short dzies,jedn;
int licznik=0;
int i = 0;
int pot,czas;

void setup(){
pinMode(a, OUTPUT);
pinMode(b, OUTPUT);
pinMode(c, OUTPUT);
pinMode(d, OUTPUT);
pinMode(e, OUTPUT);
pinMode(f, OUTPUT);
pinMode(g, OUTPUT);
digitalWrite(a,HIGH);
digitalWrite(b,HIGH);
digitalWrite(c,HIGH);
digitalWrite(d,HIGH);
digitalWrite(e,HIGH);
digitalWrite(f,HIGH);
digitalWrite(g,HIGH);
//Serial.begin(9600);
//Serial.println("licznik");
pinMode(x1,OUTPUT);
pinMode(x2,OUTPUT);
}

void clean(){
digitalWrite(a,HIGH);
digitalWrite(b,HIGH);
digitalWrite(c,HIGH);
digitalWrite(d,HIGH);
digitalWrite(e,HIGH);
digitalWrite(f,HIGH);
digitalWrite(g,HIGH);
}
void jeden(){
digitalWrite(b,LOW);
digitalWrite(c,LOW);
}
void dwa(){
digitalWrite(a,LOW);
digitalWrite(b,LOW);
digitalWrite(d,LOW);
digitalWrite(e,LOW);
digitalWrite(g,LOW);
}
void trzy(){
digitalWrite(a,LOW);
digitalWrite(b,LOW);
digitalWrite(c,LOW);
digitalWrite(d,LOW);
digitalWrite(g,LOW);
}
void cztery(){
digitalWrite(b,LOW);
digitalWrite(c,LOW);
digitalWrite(f,LOW);
digitalWrite(g,LOW);
}
void piec(){
digitalWrite(a,LOW);
digitalWrite(f,LOW);
digitalWrite(g,LOW);
digitalWrite(c,LOW);
digitalWrite(d,LOW);
}
void szesc(){
digitalWrite(a,LOW);
digitalWrite(f,LOW);
digitalWrite(e,LOW);
digitalWrite(d,LOW);
digitalWrite(c,LOW);
digitalWrite(g,LOW);
}

void siedem(){
digitalWrite(a,LOW);
digitalWrite(b,LOW);
digitalWrite(c,LOW);
}
void osiem(){
digitalWrite(a,LOW);
digitalWrite(b,LOW);
digitalWrite(c,LOW);
digitalWrite(d,LOW);
digitalWrite(e,LOW);
digitalWrite(f,LOW);
digitalWrite(g,LOW);
}
void dziewiec(){
digitalWrite(a,LOW);
digitalWrite(b,LOW);
digitalWrite(c,LOW);
digitalWrite(d,LOW);
digitalWrite(f,LOW);
digitalWrite(g,LOW);
}
void zero(){
digitalWrite(a,LOW);
digitalWrite(b,LOW);
digitalWrite(c,LOW);
digitalWrite(d,LOW);
digitalWrite(e,LOW);
digitalWrite(f,LOW);
}

void wyswietl(int last){
for(int count=0; count<(last/pause); count++){
digitalWrite(x1,HIGH);
digitalWrite(x2,LOW);
if(dzies==1){jeden();}
if(dzies==2){dwa();}
if(dzies==3){trzy();}
if(dzies==4){cztery();}
if(dzies==5){piec();}
if(dzies==6){szesc();}
if(dzies==7){siedem();}
if(dzies==8){osiem();}
if(dzies==9){dziewiec();}
if(dzies==0){zero();}
delay(pause);
clean();

digitalWrite(x1,LOW);
digitalWrite(x2,HIGH);
if(jedn==1){jeden();}
if(jedn==2){dwa();}
if(jedn==3){trzy();}
if(jedn==4){cztery();}
if(jedn==5){piec();}
if(jedn==6){szesc();}
if(jedn==7){siedem();}
if(jedn==8){osiem();}
if(jedn==9){dziewiec();}
if(jedn==0){zero();}
delay(pause);
clean();
}
}

void loop ()
{
if(digitalRead(11) == HIGH)
{
  pot=analogRead(0);
delay(500);
czas = map(pot,0,1023,10,1000);
licznik++;
jedn=licznik%10;
dzies=(licznik-jedn)/10;
wyswietl(licznik);
}
else(



}
