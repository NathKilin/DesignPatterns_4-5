class IdleState : IEnemyState
{
    public void PlayerApproached(Enemy enemy)
    {
        Console.WriteLine("[ENEMY IDLE] Player got close. Switching to PATROL.");
        enemy.SetState(new PatrolState());
    }

    public void PlayerMovedAway(Enemy enemy)
    {
        Console.WriteLine("[ENEMY IDLE] Already idle, nothing changes.");
    }

    public void PlayerDiscovered(Enemy enemy)
    {
        Console.WriteLine("[ENEMY IDLE] Can't discover player while idle.");
    }

    public void PlayerHid(Enemy enemy)
    {
        Console.WriteLine("[ENEMY IDLE] Already idle, nothing changes.");
    }
}