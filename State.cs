using Design_Patterns;

abstract class State
{
    protected Enemy Owner;
    protected StateMachine StateMachine;

    protected State(Enemy owner, StateMachine stateMachine)
    {
        Owner = owner;
        StateMachine = stateMachine;
    }

    public abstract void Enter();
    public abstract void Update();
    public abstract void Exit();

    public virtual void PlayerApproaches() { }
    public virtual void PlayerMovedAway() { }
    public virtual void PlayerDiscovered() { }
    public virtual void PlayerHid() { }
}