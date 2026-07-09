using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_combat : MonoBehaviour
{
    [SerializeField] private Transform PointAt;
    [SerializeField] private LayerMask EnemyLayer;
    public int damage = 3;
    public float radius;
    public bool AttackFinished { get; private set; }
    public void Attack()
    {
        AttackFinished = false;
        Collider2D[] enemies = Physics2D.OverlapCircleAll(PointAt.position, 0.3f, EnemyLayer);
        foreach(Collider2D enemy in enemies) enemy.GetComponent<test>().TakeDamage(damage);
    }
    public void Out()
    {
        AttackFinished = true;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(PointAt.position, radius);
    }
}
