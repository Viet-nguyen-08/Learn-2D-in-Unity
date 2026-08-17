public abstract class baseState3 
{
    protected enemy3 enemy;
    public baseState3(enemy3 enemy)
    {
        this.enemy = enemy;
    }
    public abstract void EnterState();
    public abstract void UpdateState();
    public abstract void ExitState();
}
