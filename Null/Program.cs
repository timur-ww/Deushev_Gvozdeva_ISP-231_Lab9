namespace Null
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintLength("Hello, World!");
            PrintLength(" ");
            PrintLength(null);
        }

        public static void PrintLength(string? input)
        {
            if (input != null)
            {
                Console.WriteLine($"Строка: '{input}' | Длина: {input.Length} символов");
            }
            else
            {
                Console.WriteLine("Строка отсутствует (null)");
            }
        }
    }
}
