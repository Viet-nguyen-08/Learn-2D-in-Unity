using UnityEngine;

public abstract class c_base_state  
{
    public abstract void EnterState(c state);
    public abstract void UpdateState(c state);
    public abstract void OnCollisionEnter(c state);
}
