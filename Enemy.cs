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
        
        GameManager.Instance.RegisterEnemy(this);
    }
    

    public void Update(float deltaTime) => StateMachine.CurrentState.Update(deltaTime);
    
}