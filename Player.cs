namespace Design_Patterns;

public class Player
{
    public Player()
    {
        GameManager.Instance.RegisterPlayer(this);
    }


    public void Update(float deltaTime)
    {
        while (Console.KeyAvailable)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            switch (key.Key)
            {
                case ConsoleKey.A:
                    GameManager.Instance.PlayerApproach();
                    break;
                case ConsoleKey.M:
                    GameManager.Instance.PlayerMove();
                    break;
                case ConsoleKey.H:
                    GameManager.Instance.PlayerHide();
                    break;
                case ConsoleKey.S:
                    GameManager.Instance.OnPlayerDiscoveredGlobalAlert();
                    break;
            }
        }
    }
}