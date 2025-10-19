namespace Delegates {
    internal class Program {
        public delegate void MessageHandler(string text);
        public delegate void NumberHandler(int number);
        static void Main(string[] args) {

            /*MessageHandler handler = ShowMessage;
            handler("Привет, мир");*/
            NumberHandler handler = Double;
            handler += Square;
            handler(5);
        }

        static void ShowMessage(string message) {
            Console.WriteLine($"Сообщение: {message}");
        }
        static void Double(int num) => Console.WriteLine($"Удвоено:  {num * 2}");
        static void Square(int num) => Console.WriteLine($"Квадрат:  {num * num}");

    }
}
