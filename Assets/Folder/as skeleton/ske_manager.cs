using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ske_manager : MonoBehaviour
{
    private float _moveSpeed = 3f;
    private ske_base_state _currentState;    
    // getter and setter 
    public float MoveSpeed
    {
        get => _moveSpeed;
        set => _moveSpeed = value;
    }
    public ske_base_state CurrentState
    {
        get => _currentState;
        set => _currentState = value;
    }
    void Start()
    {
        ChangeState(new ske_idle_state());
    }
    void Update()
    {
        CurrentState.UpdateState(this);
    }
    public void ChangeState(ske_base_state newState)
    {
        if(CurrentState != null)
        {
            CurrentState.ExitState(this);
        }
        CurrentState = newState;
        CurrentState.EnterState(this);
    }
 
}
