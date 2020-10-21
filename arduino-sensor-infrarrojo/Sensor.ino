int lecturaSensor1;
int lecturaSensor2;
int pinSensor1 = 42;
int pinSensor2 = 43;

void setup() {
  
  Serial.begin(9600);           //  Abrir serial com
  pinMode(pinSensor1, INPUT);   //  Activar sensores como entradas digitales
  pinMode(pinSensor2, INPUT);
  
 }

void loop() {

  //  tomar valores de los sensores -- 0 si esta pasando alguien / 1 si no esta pasando nadie

  lecturaSensor1 = digitalRead(pinSensor1);
  lecturaSensor2 = digitalRead(pinSensor2);
  
  //  Si alguno de los sensores detecta que pasa una persona
  if ((lecturaSensor1 == 0) || (lecturaSensor2 == 0)) {
          Serial.println(0);  //  Enviar mensaje por serial com a la app de escritorio
          delay(1000);        //  Esperar un segundo para volver a leer los sensores
          }
  }

}
