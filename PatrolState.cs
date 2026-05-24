using Design_Patterns;

class PatrolState : State
{
    private float _timePatrolling = .0f;
    private float _timeToPatrol = 2f;
    public PatrolState(Enemy owner, StateMachine stateMachine) : base(owner, stateMachine) { }

    public override void Enter() => Console.WriteLine($"-> [Enemy {Owner.Id}] Entered PATROL State.");

    public override void Update(float deltaTime)
    {
        _timePatrolling += deltaTime;
        Console.WriteLine($"   [Enemy {Owner.Id} - Patrol] for {_timePatrolling} seconds...");
        if (_timePatrolling >= _timeToPatrol) {
            Owner.StateMachine.ChangeState(new PatrolState(Owner,Owner.StateMachine));
        }
    }
    public override void Exit()
    {
        Console.WriteLine($"<- [Enemy {Owner.Id}] Exiting PATROL State.");
        _timePatrolling = 0;
    }

    public override void PlayerMovedAway()
    {
        Console.WriteLine($"[EVENT] Player moved away from Enemy {Owner.Id}!");
        StateMachine.ChangeState(new IdleState(Owner, StateMachine));
    }
}