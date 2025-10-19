namespace Delegates_Homework
{
    internal class Program
    {
        public delegate void Logger(string messege);

        public static void LogToConsole(string message)
        {
            Console.WriteLine($"[{DateTime.Now}] {message}");
        }
        static void Main(string[] args)
        {
            Logger logger = LogToConsole;

            logger("Программа запущена!");
        }
    }
}
