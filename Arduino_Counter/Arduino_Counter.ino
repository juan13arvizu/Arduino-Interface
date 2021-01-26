
int a=0;
int final=100;
void setup() {
Serial.begin (9600);

Serial.println("Arduino_Connected");

}

void loop() {
 for (int a=0;a<=final;a++)
  {
    Serial.println(a);
    delay(600);
  }
 }
