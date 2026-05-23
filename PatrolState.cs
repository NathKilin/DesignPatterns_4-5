using Design_Patterns;

class PatrolState : State
{
    public PatrolState(Enemy owner, StateMachine stateMachine) : base(owner, stateMachine) { }

    public override void Enter() => Console.WriteLine($"-> [Enemy {Owner.Id}] Entered PATROL State.");
    public override void Update() => Console.WriteLine($"   [Enemy {Owner.Id} - Patrol] Walking established route...");
    public override void Exit() => Console.WriteLine($"<- [Enemy {Owner.Id}] Exiting PATROL State.");

    public override void PlayerMovedAway()
    {
        Console.WriteLine($"[EVENT] Player moved away from Enemy {Owner.Id}!");
        StateMachine.ChangeState(new IdleState(Owner, StateMachine));
    }

    public override void PlayerDiscovered()
    {
        Console.WriteLine($"[EVENT] Player discovered by Enemy {Owner.Id}!");
        StateMachine.ChangeState(new AttackingState(Owner, StateMachine));
    }
}