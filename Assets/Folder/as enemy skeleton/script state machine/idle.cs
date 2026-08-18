
using UnityEngine;

public class idle : base_state
{
    public override void EnterState(manager enemy)
    {
        enemy.Ani.SetBool("idle", true);
    }
    public override void UpdateState(manager enemy)
    {
        
    }
    public override void ExitState(manager enemy)
    {
        
    }
}
