using UnityEngine;

public class c_growed : c_base_state
{
    private float startTime = 0f;
    private float time = 5f;
    public override void EnterState(c state)
    {
        Debug.Log("hello growed !");
        startTime = time;
    }
    public override void UpdateState(c state)
    {
        startTime -= Time.deltaTime;
        if(startTime <= 0f)
        {
            Debug.Log("the apple has fallen");
            state.SwitchState(state.wiltedState);
        }
    }
    public override void OnCollisionEnter(c state)
    {
        
    }
}
