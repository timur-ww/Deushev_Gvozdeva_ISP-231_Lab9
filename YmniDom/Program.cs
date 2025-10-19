public delegate void TemperatureEventHandler(string message);
public delegate void MotionEventHandler(string meassage);

namespace Program {
    internal class Program {
        static void Main(string[] args) {

            var tempSensor = new TemperatureSensor();
            var motionSensor = new MotinSensor();
            var smartLight = new SmartLight();

            tempSensor.OnOverheat += Notifier.SendTemperatureAlert;
            motionSensor.OnMotionDetected += Notifier.LogMotionEvent;
            motionSensor.OnMotionDetected += smartLight.TurnOn;

            Console.WriteLine("=== Симуляция умного дома ===");

            motionSensor.DetectMotion(true);
            smartLight.TurnOn("Обнаружение движение");
            Thread.Sleep(3000);
            smartLight.TurnOff();
            /*tempSensor.CheckTemperature(15);
            tempSensor.CheckTemperature(35);
            motionSensor.DetectMotion(false);
            motionSensor.DetectMotion(true);*/
        }
    }
}
