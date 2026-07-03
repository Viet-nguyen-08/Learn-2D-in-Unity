using UnityEngine;

public class ske_idle_state : ske_base_state
{
    public override void EnterState(ske_manager player)
    {
        player.Ani.SetBool("walk", false);
    }
    public override void UpdateState(ske_manager player)
    {
        player.MoveInput = Input.GetAxisRaw("Horizontal");
        if(player.MoveInput != 0) player.ChangeState(new ske_walk_state());
        if(Input.GetButtonDown("Jump") && player.IsGrounded) player.ChangeState(new ske_jump_state());
    }
    public override void ExitState(ske_manager player)
    {
        
    }
}
