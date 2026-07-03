using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour
{
    private base_state _currentState;
    private Animator _ani;

    // getter and setter 

    public Animator Ani { get => _ani; set => _ani = value; }
    public base_state CurrentState{ get => _currentState; set => _currentState = value;}
    
    void Awake()
    {
        Ani = GetComponent<Animator>();
    }
    void Start()
    {
        SwitchState(new idle());
    }

    void Update()
    {
        CurrentState.UpdateState(this);
    }
    public void SwitchState(base_state newState)
    {
        CurrentState = newState;
    }
}
