#include <NRFLite.h>
#include <SPI.h>
#include "OPCODES.h"


//*****RADIO*******************
NRFLite _radio;

#define RADIO_START_RANGE 1
#define RADIO_END_RANGE 6
#define MAX_RADIOS 5

uint8_t radioIDs[MAX_RADIOS] = {};  //List of all possible radios on network
uint8_t radioIndex = 0;
uint8_t thisRadioId = 2;    //TESTING, radio to recieve data's id
uint8_t otherRadioId = 2;

//BYTES:
//0: messageType
//1: radio ID
//2: transaction ID
//3-32 : payload
byte incomingPacket[32];

uint8_t data;

void findNearbyRadios()
{
  for(int i = RADIO_START_RANGE; i < RADIO_END_RANGE; i++)
  {
     uint8_t status =_radio.send(i,&data,sizeof(data));

     Serial.print("Radio on channel ");
     Serial.print(i,DEC);
     Serial.print(" : ");
     Serial.println(status);
     
     if(status == 1)
     {
        radioIDs[radioIndex] = i; 
        radioIndex++;
     }
  }
}

void listFoundRadios()
{
  Serial.println("Found radios...");
  for(int i = 0; i < MAX_RADIOS; i++)
  {
    Serial.print("Radio : ");
    Serial.println(radioIDs[i]);
  } 
}

void setup() 
{
  pinMode(LED_BUILTIN, OUTPUT);
  Serial.begin(9600);
  if(!_radio.init(thisRadioId,9,10))    //initialize the radio
    Serial.print("RADIO ERROR");  
  else
  {
    Serial.print("Radio Started on channel: ");
    Serial.println(thisRadioId,DEC);
  } 
  findNearbyRadios();

  listFoundRadios();

}

void loop() 
{
  if(_radio.hasData())
  {
     
  }
}
