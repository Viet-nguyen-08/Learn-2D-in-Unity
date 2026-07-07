
using UnityEngine;

public class attack_1 : ske_base_state
{
    public override void EnterState(ske_manager player)
    {
        player.Ani.SetTrigger("attack1");
    }
    public override void UpdateState(ske_manager player)
    {
        if(player.Combat.AttackFinished)
        {
            player.SwitchState(new ske_idle_state());
        }
    }
    public override void ExitState(ske_manager player)
    {
        
    }
}
