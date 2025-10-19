using HtmlAgilityPack;

namespace NuGet_package
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.Write("Введите URL сайта: ");
            string? url = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(url))
            {
                Console.WriteLine("URL не может быть пустым");
                return;
            }

            try
            {
                HtmlWeb web = new();

                HtmlDocument doc = web.Load(url);

                HtmlNode titleNode = doc.DocumentNode.SelectSingleNode("//title");

                if (titleNode != null)
                {
                    string title = titleNode.InnerText.Trim();
                    Console.WriteLine($"Заголовок страницы: {title}");
                }
                else
                {
                    Console.WriteLine("Заголовок не найден");
                }
            }
            catch (UriFormatException)
            {
                Console.WriteLine("Неверный формат URL");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка {ex.Message}");
            }
        }
    }
}
