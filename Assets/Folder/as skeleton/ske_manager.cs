using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ske_manager : MonoBehaviour
{
    ske_base_state currentState;
    public ske_idle_state idleState = new ske_idle_state();
    public ske_walk_state walkState = new ske_walk_state();
 
    void Start()
    {
        currentState = idleState;
        
    }

    void Update()
    {
        currentState.Update_State(this);
    }
    public void Switch_State(ske_base_state ske)
    {
        currentState = ske;
        currentState.Enter_State(this);
    }
}
