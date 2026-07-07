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
        if(player.MoveInput != 0) player.SwitchState(new ske_walk_state());
        if(Input.GetButtonDown("Jump") && player.IsGrounded) player.SwitchState(new ske_jump_state());
        if(Input.GetKeyDown(KeyCode.F)) player.SwitchState(new attack_1());
    }
    public override void ExitState(ske_manager player)
    {
        
    }
}
