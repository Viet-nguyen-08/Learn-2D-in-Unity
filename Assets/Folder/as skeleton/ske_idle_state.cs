using UnityEngine;

public class ske_idle_state : ske_base_state
{
    public override void EnterState(ske_manager player)
    {
        Debug.Log("enter idle !");
    }
    public override void UpdateState(ske_manager player)
    {
        float h = Input.GetAxisRaw("Horizontal");
        if(h != 0) player.ChangeState(new ske_walk_state());
    }
    public override void ExitState(ske_manager player)
    {
        Debug.Log("exit idle");
    }
}
