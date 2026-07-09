using UnityEngine;

public class attack_1 : ske_base_state
{
    public override void EnterState(ske_manager player)
    {
        player.Ani.SetTrigger("attack1");
    }
    public override void UpdateState(ske_manager player)
    {
        AnimatorStateInfo info = player.Ani.GetCurrentAnimatorStateInfo(0);
        if(info.normalizedTime > 1f)
        {
            player.SwitchState(new ske_idle_state());
            Debug.Log("switch state is start !");
        }
    }
    public override void ExitState(ske_manager player)
    {
        
    }
}
