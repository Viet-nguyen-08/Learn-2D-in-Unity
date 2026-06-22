using UnityEngine;

public class c_wilted : c_base_state 
{
    private float time = 0f;
    private float time_2 = 5f;
   public override void EnterState(c state)
    {
        Debug.Log("wilted state is start !");
        time = time_2;
    }
    public override void UpdateState(c state)
    {
        time -= Time.deltaTime;
        if(time <= 0f)
        {
            Debug.Log("end wilted !");
            state.SwitchState(state.growingState);
        }
    }
    public override void OnCollisionEnter(c state)
    {
        
    }
}
