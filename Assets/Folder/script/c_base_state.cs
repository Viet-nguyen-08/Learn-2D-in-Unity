using UnityEngine;

public abstract class c_base_state  
{
    public abstract void EnterState(c c);
    public abstract void UpdateState(c c);
    public abstract void OnCollisionEnter(c c);
}
