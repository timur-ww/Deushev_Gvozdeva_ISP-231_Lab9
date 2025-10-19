using Newtonsoft.Json;

namespace SmartHome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SmartLight light = new();

            light.OnStateChanged += OnLightStateChanged;

            light.PrintStatus();

            light.Toggle();
            light.SetBrightness(75);

            light.PrintStatus();

            string json = JsonConvert.SerializeObject(light);
            Console.WriteLine("\nСериализованное состояние: ");
            Console.WriteLine(json);

            Console.WriteLine("\nДесериализация состояния");
            var deserialized = JsonConvert.DeserializeObject<SmartLight>(json);
            Console.WriteLine($"Состояние: {deserialized.IsOn}, Яркость: {deserialized.Brightness}");
        }

        static void OnLightStateChanged(bool isOn)
        {
            if (isOn)
            {
                Console.WriteLine("Свет включен");
            }
            else
            {
                Console.WriteLine("Свет выключен");
            }
        }
    }
}
