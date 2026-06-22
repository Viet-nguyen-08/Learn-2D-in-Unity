using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c : MonoBehaviour
{
    c_base_state currentState;
    public c_growing growingState = new c_growing();
    public c_growed growedState = new c_growed();
    public c_wilted wiltedState = new c_wilted();

    void Start()
    {
        currentState = growingState;
        currentState.EnterState(this);
    }

 
    void Update()
    {
        currentState.UpdateState(this);
    }
    public void SwitchState(c_base_state state)
    {
        currentState = state;
        currentState.EnterState(this);
    }
}
