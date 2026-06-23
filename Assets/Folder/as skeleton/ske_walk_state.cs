using UnityEngine;

public class ske_walk_state : ske_base_state
{
    public override void EnterState(ske_manager player)
    {
        Debug.Log("enter walk state");
    }
    public override void UpdateState(ske_manager player)
    {
        float h = Input.GetAxisRaw("Horizontal");
        player.transform.Translate(Vector3.right * h * player.MoveSpeed * Time.deltaTime);
        if(h == 0) player.ChangeState(new ske_idle_state());
    }
    public override void ExitState(ske_manager player)
    {
        Debug.Log("Exit walk !");
    }
}
