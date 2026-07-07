using UnityEngine;

public class ske_walk_state : ske_base_state
{
    public override void EnterState(ske_manager player)
    {
        player.Ani.SetBool("walk", true);
    }
    public override void UpdateState(ske_manager player)
    {       
        player.MoveInput = Input.GetAxisRaw("Horizontal");
        player.Rig.velocity = new Vector2(player.MoveInput * player.MoveSpeed, player.Rig.velocity.y);
        if(player.MoveInput == 0) player.SwitchState(new ske_idle_state());
        if(player.MoveInput > 0) player.transform.localScale = new Vector3(0.66f, 0.66f, 0.66f);
        else if(player.MoveInput < 0) player.transform.localScale = new Vector3(-0.66f, 0.66f, 0.66f);
        if(Input.GetButtonDown("Jump") && player.IsGrounded) player.SwitchState(new ske_jump_state());
    }
    public override void ExitState(ske_manager player)
    {
        
    }
}
