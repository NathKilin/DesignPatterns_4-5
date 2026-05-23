class Enemy
{
    private IEnemyState _currentState;

    public Enemy()
    {
        _currentState = new IdleState();
        Console.WriteLine("Enemy spawned. State: IDLE");
    }

    public void SetState(IEnemyState newState)
    {
        _currentState = newState;
    }

    public void PlayerApproached()  => _currentState.PlayerApproached(this);
    public void PlayerMovedAway()   => _currentState.PlayerMovedAway(this);
    public void PlayerDiscovered()  => _currentState.PlayerDiscovered(this);
    public void PlayerHid()         => _currentState.PlayerHid(this);
}