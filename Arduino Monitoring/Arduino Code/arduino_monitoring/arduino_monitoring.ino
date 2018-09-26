
const int led = 2;
const int motor = 3;
const int lm35 = A0;

void setup() {
  // put your setup code here, to run once:
pinMode (led,OUTPUT);
pinMode (motor,OUTPUT);


pinMode(lm35,INPUT);
Serial.begin(9600);

}

void loop() {
  // put your main code here, to run repeatedly:
  if (Serial.available() > 0)
   {
    char opcion = Serial.read();
    switch(opcion){
      case 't':
      Serial.println(getLMTemperatura());
      break;
      case 'l':
      encenderLed();
      break;
      case 'm':
      encenderMotor();
      break;
    }
   }

   
}

float getLMTemperatura(){
  float grados = 0.0;
  float valor = 0.0;
  valor = analogRead(lm35);
  grados = valor*500/1024;
  return grados;
}

void encenderLed(){
  bool encendido = digitalRead(led);
  if(encendido){
    digitalWrite(led,LOW);
  }else{
    digitalWrite(led,HIGH);
  }
}

void encenderMotor(){
  
  bool encendido = digitalRead(motor);
  if(encendido){
    digitalWrite(motor,LOW);
  }else{
    digitalWrite(motor,HIGH);
  }
  
}

