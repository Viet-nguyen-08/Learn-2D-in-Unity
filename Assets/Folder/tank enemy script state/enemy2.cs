using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy2 : MonoBehaviour
{
    Vector2 pointA, pointB;
    Vector2 pointC, pointD;
    float elapsedTime = 0f;
    float duration = 3f;
    float time = 5f;
    void Start()
    {
        pointA = transform.position;
        pointB = new Vector2(Random.Range(-12f, 12f), Random.Range(-12f, 12f));
    }
    void forStart()
    {
        pointC = transform.position;
        pointD = new Vector2(Random.Range(-12f, 12f), Random.Range(-12f, 12f));
    }   
    void Update()
    {
        chay();
        //Debug.Log(pointA);
        //Debug.Log(pointB);
        time -= Time.deltaTime;
        //Debug.Log("time " + time);
        if(time <= 0)
        {
            forStart();
            time = 5f;
        }
        
    }
    void chay()
    {
        elapsedTime += Time.deltaTime;
        float t = elapsedTime / duration;
        transform.position = Vector2.Lerp(pointA, pointB, t);
    } 
}

/*  
public float moveTime = 2f;
    private Vector2 startPoint;
    private Vector2 targetPoint;
    private float timer;
    void Start()
    {
        NewTarget();
    }
    void Update()
    {
        timer -= Time.deltaTime;
        float t = timer / moveTime;
        transform.position = Vector2.Lerp(startPoint, targetPoint, t);
        if(t >= 1f)NewTarget();
    }    
    void NewTarget()
    {
        startPoint = transform.position;
        targetPoint = new Vector2(Random.Range(-12f, 12f), Random.Range(-12f, 12f));
        timer = 0f;
    }

*/
