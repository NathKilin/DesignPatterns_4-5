using Design_Patterns;

class Enemy
{
    public int Id { get; }
    public StateMachine StateMachine { get; }

    public Enemy(int id)
    {
        Id = id;
        StateMachine = new StateMachine();

        StateMachine.Initialize(new IdleState(this, StateMachine));
    }

    public void OnPlayerApproaches() => StateMachine.CurrentState.PlayerApproaches();
    public void OnPlayerMovedAway()  => StateMachine.CurrentState.PlayerMovedAway();
    public void OnPlayerDiscovered() => StateMachine.CurrentState.PlayerDiscovered();
    public void OnPlayerHid()        => StateMachine.CurrentState.PlayerHid();

    public void Tick() => StateMachine.CurrentState.Update();
    
    // TODO: Connect the Mediator to the enemy
}