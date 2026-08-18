using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class enemy3 : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed = 3f;
    public float moveDistance = 3f;
    [Header("Rotation")]
    public float rotationSpeed = 180f;
    [Header("State")]
    public baseState3 currentState;
    public posState3 posState;
    public rotaState3 rotaState;
    public Vector2 targetPosition;
    public float targetRotation;

    void Awake()
    {
        posState = new posState3(this);
        rotaState = new rotaState3(this);
    }

    void Start()
    {
        ChangeState(posState);
    }


    void Update()
    {
        currentState?.UpdateState();
    }
    public void ChangeState(baseState3 newState)
    {
        currentState?.ExitState();
        currentState = newState;
        currentState.EnterState();
    }

}
