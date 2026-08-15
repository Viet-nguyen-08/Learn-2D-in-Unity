using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy3 : MonoBehaviour
{
    private Vector2 _pointA, _pointB;
    private baseState3 _currentState;

    // getter and setter 
    public Vector2 PointA{get => _pointA; set => _pointA = value;}
    public Vector2 PointB{get => _pointB; set => _pointB = value;}
    public baseState3 CurrentState{get => _currentState; set => _currentState = value;}

    void Start()
    {
        SwitchState(new posState3());
    }


    void Update()
    {
        CurrentState.UpdateState(this);
    }
    public void SwitchState(baseState3 state)
    {
        if(CurrentState != null) CurrentState.ExitState(this);
        CurrentState = state;
        CurrentState.EnterState(this);
    }
}
