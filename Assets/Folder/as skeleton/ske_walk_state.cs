using UnityEngine;

public class ske_walk_state : ske_base_state
{
    public override void EnterState(ske_manager player)
    {
        player.Ani.SetBool("walk", true);
        Debug.Log("enter walk state");
    }
    public override void UpdateState(ske_manager player)
    {       
        float h = Input.GetAxisRaw("Horizontal");
        player.transform.Translate(Vector3.right * h * player.MoveSpeed * Time.deltaTime);
        if(h == 0) player.ChangeState(new ske_idle_state());
        if(h > 0) player.transform.localScale = new Vector3(0.66f, 0.66f, 0.66f);
        else if(h < 0) player.transform.localScale = new Vector3(-0.66f, 0.66f, 0.66f);
        if(Input.GetButtonDown("Jump") && player.IsGrounded) player.ChangeState(new ske_jump_state());
    }
    public override void ExitState(ske_manager player)
    {
        Debug.Log("Exit walk !");
    }
}
