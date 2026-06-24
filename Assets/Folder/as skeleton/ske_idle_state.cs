using UnityEngine;

public class ske_idle_state : ske_base_state
{
    public override void EnterState(ske_manager player)
    {
        player.Ani.SetBool("walk", false);
        Debug.Log("enter idle !");
    }
    public override void UpdateState(ske_manager player)
    {
        float h = Input.GetAxisRaw("Horizontal");
        if(h != 0) player.ChangeState(new ske_walk_state());
        if(Input.GetButtonDown("Jump") && player.IsGrounded) player.ChangeState(new ske_jump_state());
    }
    public override void ExitState(ske_manager player)
    {
        Debug.Log("exit idle");
    }
}
