using MyClass;
using Newtonsoft.Json;
using HtmlAgilityPack;

namespace Program 
    {
    internal class Program 
    {
        static void Main(string[] args) 
        {
            /*Person2 anton = new("Anton");

            // Шаг 2. Установка пакетов Nuget 

            Fruit apple = new() { Name = "Яблоко", Quantity = 5 };

            string json = JsonConvert.SerializeObject(apple);
            Console.WriteLine("В JSON: " + json);

            var deserialized = JsonConvert.DeserializeObject<Fruit>(json);
            Console.WriteLine($"Объект: {deserialized?.Name} - { deserialized?.Quantity} шт.");*/

            // Шаг 7. Примеры использования null 

            /*string? GetUserName(int id) {
                return id == 1 ? "Alice" : null;
            }

            var user = GetUserName(2);
            Console.WriteLine(user?.ToUpper());

            string? input = Console.ReadLine();

            if (input != null)
                Console.WriteLine($"Вы ввели: {input}");
            else
                Console.WriteLine("Вы ничего не ввели!");

            List<string?> names = new() { "Anna", null, "Bob" };

            foreach (var name in names) {
                Console.WriteLine(name?.Length ?? 0);
            }*/

            // Шаг 8. System.Nullable<T>

            /*int? number1 = 5;
            Nullable<int> number2 = 5;

            PrintNullable(5);
            PrintNullable(null);

            void PrintNullable(int? number) {
                if (number.HasValue) {
                    Console.WriteLine(number.Value);
                    Console.WriteLine(number);
                }
                else {
                    Console.WriteLine("параметр равен null");
                }
            }

            int? number = null;
            Console.WriteLine(number.Value);
            Console.WriteLine(number);*/

            int? number = null;

            Console.WriteLine(number.GetValueOrDefault());
            Console.WriteLine(number.GetValueOrDefault(10));

            number = 15;
            Console.WriteLine(number.GetValueOrDefault());
            Console.WriteLine(number.GetValueOrDefault(10));


        }

        static async Task Main() {
            Console.Write("Введите URL сайта: ");
            string? url = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(url)) {
                try {
                    HttpClient client = new();
                    string html = await client.GetStringAsync(url);

                    HtmlDocument doc = new();
                    doc.LoadHtml(html);
                    var titleNode = doc.DocumentNode.SelectSingleNode("//title");

                    if (titleNode != null) {
                        Console.WriteLine($" Заголовок страницы: {titleNode.InnerText}");

                    } else {
                        Console.WriteLine("Заголовок страницы не найден");
                    }
                }
                catch(Exception ex) {
                    Console.WriteLine("Ошибка: " + ex.Message);
                }
            }
            else {
                Console.WriteLine("URL не может быть пустым.");
            }

            // Шаг 3.  Null и ссылочные типы 

            /*string name = null;
            Console.WriteLine(name.Length);

            string onNullableName = "Ария";
            string? nullableName = null;

            Console.WriteLine(nullableName?.Length);

            string? text = null;
            Console.WriteLine(text?.Length);

            string? name = null;
            string result = name ?? "Default";

            string? name = null;
            Console.WriteLine(name!.Length);*/

            /*#nullable disable
            string name = null;
            Console.WriteLine(name!.Length);

            #nullable enable
            string hero = null;*/

            //Шаг 4.  Null и значимые типы

            //






        }
    }
}

