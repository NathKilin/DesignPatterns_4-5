class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== ENEMY AI STATE PATTERN DEMO ===\n");

        Enemy enemy = new Enemy();

        Console.WriteLine("\n-- Player approaches --");
        enemy.PlayerApproached();

        Console.WriteLine("\n-- Player is discovered --");
        enemy.PlayerDiscovered();

        Console.WriteLine("\n-- Player hides --");
        enemy.PlayerHid();

        Console.WriteLine("\n-- Player moves away --");
        enemy.PlayerMovedAway();

        Console.WriteLine("\n-- Player approaches again --");
        enemy.PlayerApproached();

        Console.WriteLine("\nDone. Press any key to exit.");
        Console.ReadKey();
    }
}