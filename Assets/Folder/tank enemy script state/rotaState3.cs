using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotaState3 : baseState3
{   
    public rotaState3(enemy3 enemy) : base(enemy)
    {
        
    }
    public override void EnterState()
    {
        float randomAngle = Random.Range(-120f, 120f);
        enemy.targetRotation = enemy.transform.eulerAngles.z + randomAngle;
    }
    public override void UpdateState()
    {
        float currentRotation = enemy.transform.eulerAngles.z;
        float newRotation = Mathf.MoveTowardsAngle(currentRotation, enemy.targetRotation, enemy.rotationSpeed * Time.deltaTime);
        enemy.transform.rotation = Quaternion.Euler(0f, 0f, newRotation);
        float angleDifference = Mathf.Abs(Mathf.DeltaAngle(newRotation, enemy.targetRotation));
        if(angleDifference < 0.1f) enemy.ChangeState(enemy.posState);
    }
    public override void ExitState()
    {
        
    }
    
}
