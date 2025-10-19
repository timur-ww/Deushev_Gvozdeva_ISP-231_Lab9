namespace Event_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thermometer thermometer = new();

            thermometer.TemperatureTooHigh += OnTemperatureTooHigh;

            thermometer.Measure(25);
            thermometer.Measure(75);
            thermometer.Measure(105);
            thermometer.Measure(80);
            thermometer.Measure(200);

        }
        static void OnTemperatureTooHigh()
        {
            Console.WriteLine("Привышена критическая температура! \n");
        }
    }
}
