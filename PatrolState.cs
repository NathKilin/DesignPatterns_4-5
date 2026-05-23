class PatrolState : IEnemyState
{
    public void PlayerApproached(Enemy enemy)
    {
        Console.WriteLine("[ENEMY PATROL] Player is close. Already patrolling.");
    }

    public void PlayerMovedAway(Enemy enemy)
    {
        Console.WriteLine("[ENEMY PATROL] Player moved away. Going back to IDLE.");
        enemy.SetState(new IdleState());
    }

    public void PlayerDiscovered(Enemy enemy)
    {
        Console.WriteLine("[ENEMY PATROL] Player spotted! Switching to ATTACKING.");
        enemy.SetState(new AttackingState());
    }

    public void PlayerHid(Enemy enemy)
    {
        Console.WriteLine("[PATROL] Player hid. Still patrolling.");
    }
}