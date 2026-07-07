
using UnityEngine;

public class attack_1 : ske_base_state
{
    private bool hasHit;
    public override void EnterState(ske_manager player)
    {
        hasHit = false;
        player.Ani.SetTrigger("attack1");
    }
    public override void UpdateState(ske_manager player)
    {
        if (!hasHit)
        {
            Collider2D[] enemies = Physics2D.OverlapCircleAll(player.PointAt.position, 0.3f, player.EnemyLayer);
            foreach(Collider2D enemy in enemies) enemy.GetComponent<test>().TakeDamage(2);
            hasHit = true;
        }
    }
    public override void ExitState(ske_manager player)
    {
        
    }
}
