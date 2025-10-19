using MathLibrary;

namespace Class_Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathTools math = new();

            Console.WriteLine($"Add: {math.Add(3, 5)}");
            Console.WriteLine($"Multiply: {math.Multiply(3, 5)}");
        }
    }
}
