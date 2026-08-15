using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class posState3 : baseState3
{
    public override void EnterState(enemy3 enemy)
    {
        enemy.PointA = enemy.transform.position;
        enemy.PointB = new Vector2(Random.Range(-12f, 12f), Random.Range(-12f, 12f));
    }
    public override void UpdateState(enemy3 enemy)
    {
        Debug.Log(enemy.PointA);
        Debug.Log(enemy.PointB);
    }
    public override void ExitState (enemy3 enemy){

    }
}
