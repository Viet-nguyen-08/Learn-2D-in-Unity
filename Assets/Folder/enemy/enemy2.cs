using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy2 : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 200f;
    private float ran, ran2;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {        
        if (Input.GetKeyDown(KeyCode.F))
        {
            transform.position = new Vector2(ran, ran2);
            ran = Random.Range(-6, 6);
            ran2 = Random.Range(-6, 6);
        }
    }
    
}
