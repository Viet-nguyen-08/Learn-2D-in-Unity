using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public float health = 10f;
    private Animator ani;
    void Awake()
    {
        ani = GetComponent<Animator>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(float damage)
    {
        ani.SetTrigger("takedamage");
        health -= damage;
        Debug.Log("enemy is " + health + " hp");
        if(health <= 0f) Debug.Log("enemy is deal");
    }
}
