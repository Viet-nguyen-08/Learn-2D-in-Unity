using UnityEngine;

public class c_growing : c_base_state 
{
    Vector3 startGr = new Vector3(1f, 1f, 1f);
    Vector3 growing = new Vector3(1f, 1f, 1f);
    public override void EnterState(c state)
    {
        state.transform.localScale = startGr;
    }
    public override void UpdateState(c state)
    {
        if(state.transform.localScale.x < 2)
        {
            state.transform.localScale += growing * Time.deltaTime;
        }
        else
        {
            // bộ chuyển đổi trạng thái 
            state.SwitchState(state.growedState);
        }
    }
    public override void OnCollisionEnter(c state)
    {
        
    }
}
