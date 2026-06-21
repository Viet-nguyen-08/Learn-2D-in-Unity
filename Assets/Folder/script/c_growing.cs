using UnityEngine;

public class c_growing : c_base_state 
{
    Vector3 startGr = new Vector3(1f, 1f, 1f);
    Vector3 growing = new Vector3(1f, 1f, 1f);
    public override void EnterState(c c)
    {
        c.transform.localScale = startGr;
    }
    public override void UpdateState(c c)
    {
        if(c.transform.localScale.x < 2)
        {
            c.transform.localScale += growing * Time.deltaTime;
        }
        else
        {
            c.SwitchState(c.growedState);
        }
    }
    public override void OnCollisionEnter(c c)
    {
        
    }
}
