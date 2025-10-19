namespace Events {
    internal class Program {
        static void Main(string[] args) {
            Player player = new();
            player.OnDeath += () => Console.WriteLine("Враги празднуют победу!!!!!!!!!");
            player.OnDeath += ShowGameOver;
            player.TakeDamage(100);
        }

        static void ShowGameOver() => Console.WriteLine("GAME OVER");
    }
}
