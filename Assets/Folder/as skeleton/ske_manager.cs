using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ske_manager : MonoBehaviour
{
    public float _moveSpeed = 3f;
    public float _jumpFoce = 5f;
    private ske_base_state _currentState; 
    private Animator _animator;   
    private Rigidbody2D _rig;
    public Transform _groundCheck;
    public LayerMask _groundLayer;
    private bool _isGrounded;


    // getter and setter 
    public float MoveSpeed
    {
        get => _moveSpeed;
        set => _moveSpeed = value;
    }
    public float JumpFoce
    {
        get => _jumpFoce;
        set => _jumpFoce = value;
    }
    public ske_base_state CurrentState
    {
        get => _currentState;
        set => _currentState = value;
    }
    public Animator Ani
    {
        get => _animator;
        set => _animator = value;
    }
    public Rigidbody2D Rig
    {
        get => _rig;
        set => _rig = value;
    }
    public Transform GroundCheck
    {
        get => _groundCheck;
        set => _groundCheck = value;
    }
    public LayerMask GroundLayer
    {
        get => _groundLayer;
        set => _groundLayer = value;
    }
    public bool IsGrounded
    {
        get => _isGrounded;
        set => _isGrounded = value;
    }
    void Awake()
    {
        Ani = GetComponent <Animator>();
        Rig = GetComponent <Rigidbody2D>();        
    }
    void Start()
    {        
        ChangeState(new ske_idle_state());
    }
    void Update()
    {
        IsGrounded = Physics2D.OverlapCircle(GroundCheck.position, 0.2f, GroundLayer);
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
