using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float speed = 3f;
    private Rigidbody2D rb;
    private Vector2 moveInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        InvokeRepeating(nameof(ChangeDirection), 0f, 2f);
    }

    void FixedUpdate()
    {
        Vector2 direction = transform.up;
        rb.velocity = direction * moveInput * speed;
    }
    void ChangeDirection()
    {
        float horizontal = Random.Range(-1, 2); // -1, 0, 1
        float vertical = Random.Range(-1, 2); 
        moveInput = new Vector2(horizontal, vertical).normalized;
        float rotate = Random.Range(0, 90);
        
    }
}
