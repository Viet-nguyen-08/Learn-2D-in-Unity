using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_combat_2 : MonoBehaviour
{
    [SerializeField] private Transform point;
    [SerializeField] private LayerMask layer;
    [SerializeField] private int damage = 4;
    [SerializeField] private float radius;
    private Animator ani;

    void Damage()
    {
        Collider2D[] enemies = Physics2D.OverlapCircleAll(point.position, radius, layer);
        foreach(Collider2D enemy in enemies) enemy.GetComponent<test>().TakeDamage(damage);
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(point.position, radius);
    }
}
