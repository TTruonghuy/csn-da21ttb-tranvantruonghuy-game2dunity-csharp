using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Test : MonoBehaviour
{
    private Rigidbody2D rb;
    public Transform target; // vị trí nhân vật
    public float speed = 5; //tốc độ
    public float rotateSpeed = 600; // độ bám                               
    int hp = 0;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Vector2 pos = transform.position; // lấy vị trí
        if (pos.y > -18) 
        {
            Vector2 direction = (Vector2)target.position - rb.position;
            direction.Normalize();
            float rotateAmout = Vector3.Cross(direction, transform.up).z;
            rb.angularVelocity = -rotateAmout * rotateSpeed;
            rb.velocity = transform.up * speed;
        }
        else 
        {
            rb.gravityScale = 0f;
            rb.angularVelocity = 0f;
            rb.velocity = Vector3.zero;
        }
        speed += Time.deltaTime * 0.009f;
        thoigiantang += Time.deltaTime;
        if (thoigiantang >= 4)
        {
            pointt++; thoigiantang = 0;
        }
    }
    public int pointt = 0;
    float thoigiantang = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
           hp++;  
            if(pointt <= 15)
            { 
               if (hp == 2)
               {
                Destroy(this.gameObject);
               }
            }
            if(pointt > 15)
            { 
                if (hp == 3)
                {
                    Destroy(this.gameObject);
                }
            }
            if (pointt > 30)
            {
                if (hp == 5)
                {
                    Destroy(this.gameObject);
                }
            }
            if (pointt > 45)
            {
                if (hp == 6)
                {
                    Destroy(this.gameObject);
                }
            }
        }
        if (collision.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
    }
}

