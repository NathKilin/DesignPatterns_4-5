class GameManager
{
    private static GameManager _instance;
    private static readonly object _lock = new object();
    private List<Enemy> _enemies = new List<Enemy>();

    public static GameManager Instance
    {
        get
        {
            lock (_lock)
            {
                if (_instance == null) _instance = new GameManager();
                return _instance;
            }
        }
    }

    public void RegisterEnemy(Enemy enemy) => _enemies.Add(enemy);

    public void OnPlayerDiscoveredGlobalAlert(Enemy spotter)
    {
        Console.WriteLine($"\n[MEDIATOR] GameManager broadcasting alert! Enemy {spotter.Id} spotted the player.");

        foreach (var enemy in _enemies)
        {
            if (enemy != spotter && enemy.StateMachine.CurrentState is PatrolState)
            {
                Console.WriteLine($"[MEDIATOR] Forcing Enemy {enemy.Id} to assist in combat!");
                enemy.StateMachine.ChangeState(new AttackingState(enemy, enemy.StateMachine));
            }
        }
    }
    
    // TODO: Connect the Mediator to the enemy
}