using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ske_manager : MonoBehaviour
{
    ske_base_state currentState;
    public ske_idle_state idleState = new ske_idle_state();
    public ske_walk_state walkState = new ske_walk_state();
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
