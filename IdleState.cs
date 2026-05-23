namespace Design_Patterns;

class IdleState : State
{
    public IdleState(Enemy owner, StateMachine stateMachine) : base(owner, stateMachine) { }

    public override void Enter() => Console.WriteLine($"-> [Enemy {Owner.Id}] Entered IDLE State.");
    public override void Update() => Console.WriteLine($"   [Enemy {Owner.Id} - Idle] Standing guard...");
    public override void Exit() => Console.WriteLine($"<- [Enemy {Owner.Id}] Exiting IDLE State.");

    public override void PlayerApproaches()
    {
        Console.WriteLine($"[EVENT] Player approached Enemy {Owner.Id}!");
        StateMachine.ChangeState(new PatrolState(Owner, StateMachine));
    }
}