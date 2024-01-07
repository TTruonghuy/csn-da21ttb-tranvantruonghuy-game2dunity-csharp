using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG3 : MonoBehaviour
{
    public float realVelocity = 0.5f; // tốc độ 
    public float xMax = 1f;    //điểm cuối
    public float xMin = 1f;    //điểm dịch chuyển trở lại
    void FixedUpdate()
    {
        Vector2 pos = transform.position; //lấy vị trí 
        pos.x -= realVelocity * Time.fixedDeltaTime; //di chuyển sang trái
        if (pos.x <= xMax) //thực hiện dịch chuyển nếu đến điểm x=
            pos.x = xMin;
        transform.position = pos;//cập nhật lại biến pos
    }
}
