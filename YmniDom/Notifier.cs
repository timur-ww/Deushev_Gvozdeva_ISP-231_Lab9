public class Notifier {
    public static void SendTemperatureAlert(string message) {
        Console.WriteLine($"[Уведомление] {message}");
    }
    public static void LogMotionEvent(string message) {
        Console.WriteLine($"[Лог] {message} (время: {DateTime.Now})");
    }
}