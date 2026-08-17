using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class posState3 : baseState3
{
    public posState3(enemy3 enemy) : base(enemy)
    {        
    }
    
    public override void EnterState()
    {
        Vector2 forward = enemy.transform.up;
        float distance = Random.Range(enemy.moveDistance * 0.5f, enemy.moveDistance);
        enemy.targetPosition = (Vector2)enemy.transform.position + forward * distance;
    }
    public override void UpdateState()
    {
        enemy.transform.position = Vector2.MoveTowards(enemy.transform.position, enemy.targetPosition, enemy.moveSpeed * Time.deltaTime);
        float distance = Vector2.Distance(enemy.transform.position, enemy.targetPosition);
        if(distance < 0.05f) enemy.ChangeState(enemy.rotaState);
    }
    public override void ExitState ()
    {
        
    }    
}
