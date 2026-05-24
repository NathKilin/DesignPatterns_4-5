namespace Design_Patterns;

class GameManager
{
    private static GameManager _instance;
    private static readonly object _lock = new object();
    private List<Enemy> _enemies = new List<Enemy>();

    private Player? _player = null;
    
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
    
    
    public void Update(float deltaTime)
    {
        // Loop through all the entities in the scene ( only enemies and the player in our case ) and call update in them
        
        foreach (Enemy enemy in _enemies) {
            enemy.Update(deltaTime);
        }

        if (_player != null) {
            _player.Update(deltaTime);
        } else {
            Console.WriteLine("Player is null");  
        }
    }
    
    
    public void RegisterPlayer(Player player)
    {
        _player = player;
    }
    public void RegisterEnemy(Enemy enemy) => _enemies.Add(enemy);

    public void OnPlayerDiscoveredGlobalAlert()
    {
        foreach (Enemy enemy in _enemies)
        {
            if (enemy.StateMachine.CurrentState is PatrolState)
            {
                Console.WriteLine($"[MEDIATOR] Forcing Enemy {enemy.Id} to assist in combat!");
                enemy.StateMachine.ChangeState(new AttackingState(enemy, enemy.StateMachine));
            }
        }
    }


    public void PlayerApproach()
    {
        foreach (Enemy enemy in _enemies)
        {
            enemy.StateMachine.CurrentState.PlayerApproaches();
        }
    }


    public void PlayerMove()
    {
        foreach (Enemy enemy in _enemies)
        {
            enemy.StateMachine.CurrentState.PlayerMovedAway();
        }
    }


    public void PlayerHide()
    {
        foreach (Enemy enemy in _enemies)
        {
            enemy.StateMachine.CurrentState.PlayerHid();
        }
    }
}