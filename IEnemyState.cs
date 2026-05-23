interface IEnemyState
{
    void PlayerApproached(Enemy enemy);
    void PlayerMovedAway(Enemy enemy);
    void PlayerDiscovered(Enemy enemy);
    void PlayerHid(Enemy enemy);
}