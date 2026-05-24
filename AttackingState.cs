using Design_Patterns;

class AttackingState : State
{
    public AttackingState(Enemy owner, StateMachine stateMachine) : base(owner, stateMachine) { }

    public override void Enter()
    {
        Console.WriteLine($"-> [Enemy {Owner.Id}] Entered ATTACKING State.");
        GameManager.Instance.OnPlayerDiscoveredGlobalAlert();
    }
    public override void Update(float dT) => Console.WriteLine($"   [Enemy {Owner.Id} - Attacking] Firing weapons at the target!");
    public override void Exit() => Console.WriteLine($"<- [Enemy {Owner.Id}] Exiting ATTACKING State.");

    public override void PlayerHid()
    {
        Console.WriteLine($"[EVENT] Player hid from Enemy {Owner.Id}!");
        StateMachine.ChangeState(new PatrolState(Owner, StateMachine));
    }
}