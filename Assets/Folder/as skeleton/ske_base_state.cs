using UnityEngine;

public abstract class ske_base_state 
{
   public abstract void Enter_State(ske_manager ske);
    public abstract void Update_State(ske_manager ske);
    public abstract void OnCollisionEnter(ske_manager ske);    
}
