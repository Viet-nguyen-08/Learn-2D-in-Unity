using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float speed;
    private Transform target;
    public float dis;
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    void Update()
    {
        if(Vector2.Distance(transform.position, target.position) > dis)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        } 
        // Tính toán hướng từ Enemy đến Player
        Vector2 direction = target.position - transform.position;
        // Xoay đối tượng hướng về phía Player
        // Nếu sprite của bạn mặc định hướng lên trên hoặc sang phải,
        // bạn có thể cần điều chỉnh góc xoay thêm (ví dụ -90f hoặc 90f)
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, angle -90);
        
    }
}
