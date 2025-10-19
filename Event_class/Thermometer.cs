public class Thermometer
{
    public event Action TemperatureTooHigh;

    public void Measure(int value)
    {
        Console.WriteLine($"Измерена температура: {value}°C");
        Console.WriteLine("Температура в норме \n");

        if (value > 100)
        {
            Console.WriteLine("Температура привышает 100°C!");

            TemperatureTooHigh?.Invoke();
        }
    }

}