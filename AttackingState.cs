class AttackingState : IEnemyState
{
    public void PlayerApproached(Enemy enemy)
    {
        Console.WriteLine("[ENEMY ATTACKING] Player is right here. Keep attacking!");
    }

    public void PlayerMovedAway(Enemy enemy)
    {
        Console.WriteLine("[ENEMY ATTACKING] Player ran away. Going back to PATROL.");
        enemy.SetState(new PatrolState());
    }

    public void PlayerDiscovered(Enemy enemy)
    {
        Console.WriteLine("[ENEMY ATTACKING] Already attacking. Nothing changes.");
    }

    public void PlayerHid(Enemy enemy)
    {
        Console.WriteLine("[ENEMY ATTACKING] Player hid! Switching to PATROL to search.");
        enemy.SetState(new PatrolState());
    }
}
