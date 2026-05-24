namespace Design_Patterns;

class IdleState : State
{
    private float _timeIdling = .0f;
    private float _timeToIdle = 2f;
    
    public IdleState(Enemy owner, StateMachine stateMachine) : base(owner, stateMachine) { }

    public override void Enter()
    {
        Console.WriteLine($"-> [Enemy {Owner.Id}] Entered IDLE State.");
    }
    public override void Update(float dT)
    {
        _timeIdling += dT;
        Console.WriteLine($"   [Enemy {Owner.Id} - Idle] Standing guard for {_timeIdling} seconds...");
        if (_timeIdling >= _timeToIdle) {
            Owner.StateMachine.ChangeState(new PatrolState(Owner,Owner.StateMachine));
        }
    }
    public override void Exit() 
    {
        Console.WriteLine($"<- [Enemy {Owner.Id}] Exiting IDLE State.");
        _timeIdling = .0f;
    }

    public override void PlayerApproaches()
    {
        Console.WriteLine($"[EVENT] Player approached Enemy {Owner.Id}!");
        StateMachine.ChangeState(new PatrolState(Owner, StateMachine));
    }
}