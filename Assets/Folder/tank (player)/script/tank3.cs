using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tank3 : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 200f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Nhận input
        float moveInput = Input.GetAxisRaw("Vertical");   // W/S
        float rotateInput = Input.GetAxisRaw("Horizontal"); // A/D

        // Xoay nhân vật (A/D)
        transform.Rotate(Vector3.forward * -rotateInput * rotationSpeed * Time.deltaTime);

        // Di chuyển theo hướng đang quay mặt (W/S)
        Vector2 direction = transform.up; // "up" là hướng nhân vật nhìn trong 2D
        rb.velocity = direction * moveInput * moveSpeed;
    }
}
