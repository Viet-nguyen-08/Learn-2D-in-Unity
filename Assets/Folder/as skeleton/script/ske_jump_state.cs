using UnityEngine;

public class ske_jump_state : ske_base_state
{
    public override void EnterState(ske_manager player)
    {
        player.MoveInput = Input.GetAxisRaw("Horizontal");
        player.Rig.velocity = new Vector2(player.MoveInput * player.MoveSpeed, player.Rig.velocity.y);
        player.Ani.SetTrigger("jump"); 
        if(Input.GetButtonDown("Jump") && player.IsGrounded) 
        {
            player.Rig.velocity = new Vector2(player.Rig.velocity.x, player.JumpFoce);
        }               
    }
    public override void UpdateState(ske_manager player)
    {                
        if(player.Rig.velocity.y < 0) 
        {
            player.ChangeState(new ske_idle_state());
        }
    }
    public override void ExitState(ske_manager player)
    {
        
    }
}