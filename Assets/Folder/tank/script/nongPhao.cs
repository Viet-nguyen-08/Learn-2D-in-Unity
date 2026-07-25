using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nongPhao : MonoBehaviour
{
    [SerializeField] private int rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Lấy vị trí chuột trong thế giới
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0f;

        // Vector từ nòng súng đến chuột
        Vector3 direction = mousePos - transform.position;

        // Góc mục tiêu (theo trục Z)
        float targetAngle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        float offset = 90f; // đổi thành -90f nếu muốn xoay ngược lại
        targetAngle += offset;

        // Góc hiện tại
        float currentAngle = transform.eulerAngles.z;

        // Xoay dần về góc mục tiêu
        float angle = Mathf.MoveTowardsAngle(currentAngle, targetAngle, rotationSpeed * Time.deltaTime);

        // Gán rotation mới
        transform.rotation = Quaternion.Euler(0f, 0f, angle);
    }
}
