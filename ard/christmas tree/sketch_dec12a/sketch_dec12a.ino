#include <Adafruit_NeoPixel.h>

#define PIN            5
#define NUMPIXELS      9


Adafruit_NeoPixel pixels = Adafruit_NeoPixel(NUMPIXELS, PIN, NEO_GRB + NEO_KHZ800);

void setup()
{
  // put your setup code here, to run once:
pixels.begin();
Serial.begin(9600); 
}

int program = 1;
int beforeVal = 2;

void loop()
{
  
   
        for(int hue = 0; hue < 360; hue++)
       {
        setLedColorHSV_normal(hue, 1, 1); 
 delay(50);       }
      
      
  
   
    

}

void setLedColorHSV_normal(int h, double s, double v) {

  double r=0; 
  double g=0; 
  double b=0;
  double hf=h/60.0;

  int i=(int)floor(h/60.0);
  double f = h/60.0 - i;
  double pv = v * (1 - s);
  double qv = v * (1 - s*f);
  double tv = v * (1 - s * (1 - f));

  switch (i)
  {
  case 0:
    r = v;
    g = tv;
    b = pv;
    break;
  case 1:
    r = qv;
    g = v;
    b = pv;
    break;
  case 2: 
    r = pv;
    g = v;
    b = tv;
    break;
  case 3:
    r = pv;
    g = qv;
    b = v;
    break;
  case 4:
    r = tv;
    g = pv;
    b = v;
    break;
  case 5:
    r = v;
    g = pv;
    b = qv;
    break;
  }

  //set each component to a integer value between 0 and 255
  int red = constrain((int)255*r,0,255);
  int green = constrain((int)255*g,0,255);
  int blue = constrain((int)255*b,0,255);
  
  
  for(int i = 0; i < 9; i++) 
    {
      pixels.setPixelColor(i, pixels.Color(red, green, blue));
     }
 
  pixels.show();
  
}

void setLedColorHSV(int h, double s, double v) {

  double r=0; 
  double g=0; 
  double b=0;
  double hf=h/60.0;

  int i=(int)floor(h/60.0);
  double f = h/60.0 - i;
  double pv = v * (1 - s);
  double qv = v * (1 - s*f);
  double tv = v * (1 - s * (1 - f));

  switch (i)
  {
  case 0:
    r = v;
    g = tv;
    b = pv;
    break;
  case 1:
    r = qv;
    g = v;
    b = pv;
    break;
  case 2: 
    r = pv;
    g = v;
    b = tv;
    break;
  case 3:
    r = pv;
    g = qv;
    b = v;
    break;
  case 4:
    r = tv;
    g = pv;
    b = v;
    break;
  case 5:
    r = v;
    g = pv;
    b = qv;
    break;
  }

  //set each component to a integer value between 0 and 255
  int red = constrain((int)255*r,0,255);
  int green = constrain((int)255*g,0,255);
  int blue = constrain((int)255*b,0,255);

  chainsUp(red, green, blue); //rozowy
  chainsDN(red, green, blue);
  pixels.show();
  
}

void resetLEDs()
{
   for(int i = 0; i < 9; i++) 
    {
      pixels.setPixelColor(i, 0,0,0);
      //pixels.setPixelColor(1, pixels.Color(red, green, blue));
     // pixels.setBrightness(64);
     pixels.show();
     }
}

void rainbow()
{
  resetLEDs();
 
     for(int i = 0; i < 9; i++) 
    {
   pixels.setPixelColor(i, 255,0,0);
   pixels.show();
   delay(200);
   resetLEDs();
    }
     for(int i = 0; i < 9; i++) 
    {
    //reset();
   pixels.setPixelColor(i,0, 255,0);
   pixels.show();
   delay(200);
   resetLEDs();
    }
     for(int i = 0; i < 9; i++) 
    {
    //reset();
   pixels.setPixelColor(i,0,0,255);
   pixels.show();
   delay(200);
   resetLEDs();
    }
  
}

void chainsUp(int x, int y, int z)
{
  for(int m = 0; m <9; m++)
  {
    //resetLEDs();
    pixels.setPixelColor(m,x,y,z);
    pixels.setPixelColor(m+1,x,y,z);
    pixels.show();
    delay(30);
    resetLEDs();
    m = m +1;
  }
}

void chainsDN(int x, int y, int z)
{
  for(int p = 8; p > 0 ;p --)
  {
    //resetLEDs();
    pixels.setPixelColor(p,x,y,z);
    pixels.setPixelColor(p-1,x,y,z);
    pixels.show();
   delay(30);
    resetLEDs();
    p = p - 1;
  }
}

void lastShow()
{
  
  
  for(int h= 0; h<101; h++)
  {
  setLedColorHSV(360,100, h);
  delay(50);
  }
}

