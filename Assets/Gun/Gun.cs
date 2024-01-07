using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using static UnityEditor.PlayerSettings;

public class gun : MonoBehaviour
{
    public GameObject bullet;
    public Transform firePos;
    public float TimeFire = 1f;
    public float bulletForce; // lực bắn
    private float timeFire; 
    public float minAngle = -10f; //góc quay xuống của gun
    public float maxAngle = 45f;   // góc quay lên của gun
    public Joystick joystick;
    void Update()
    {
        Vector2 direction = joystick.Direction;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        angle = Mathf.Clamp(angle, minAngle, maxAngle);
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        timeFire -= Time.deltaTime;
        if(timeFire < 0 )
        {
            Fire();
        }
        TimeFire -= Time.deltaTime * 0.001f;
    }
    private void Fire()
    {
        timeFire = TimeFire;
        GameObject bulletTmp = Instantiate(bullet, firePos.position, Quaternion.identity);
        Rigidbody2D rb = bulletTmp.GetComponent<Rigidbody2D>();
        rb.AddForce(transform.right * bulletForce, ForceMode2D.Impulse);
        Vector2 poss = bulletTmp.transform.position;
    }
}
