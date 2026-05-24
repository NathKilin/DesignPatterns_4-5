using System.Diagnostics;
using Design_Patterns;

class Program
{
    public static readonly bool IsRunning = true;

    private static Enemy _enemy1 = null;
    private static Player _player = null;
    
    static void Main(string[] args)
    {
        Console.WriteLine("Player, Enemies, GameManager simulation");
        Console.WriteLine("Enemies use a simple primitive state machine");
        Console.WriteLine("\nKeybinds : ");
        Console.WriteLine("--------------------");
        Console.WriteLine("[A] - Approach");
        Console.WriteLine("[M] - Move");
        Console.WriteLine("[H] - Hide");
        Console.WriteLine("[S] - Simulate Spotted");
        Console.WriteLine("--------------------");
        Console.WriteLine("\nPress any key to start...");
        Console.ReadKey();
        _enemy1 = new Enemy(1);
        _player = new Player();
        GameLoop();
    }


    private static void GameLoop()
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        
        long previousTime = stopwatch.ElapsedMilliseconds;
        while (IsRunning)
        {
            // Delta Time & Update Calculations
            long currentTime = stopwatch.ElapsedMilliseconds;
            float deltaTime = (stopwatch.ElapsedMilliseconds - previousTime) / 1000.0f;
            previousTime = currentTime;
            
            GameManager.Instance.Update(deltaTime);
            
            Thread.Sleep(1);
        }
    }
}