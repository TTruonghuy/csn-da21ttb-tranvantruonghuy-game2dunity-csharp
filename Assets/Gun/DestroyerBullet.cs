using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerBullet : MonoBehaviour
{
    private void Update()
    {
        Vector2 pos = transform.position;
        if (pos.y >= 17.25f | pos.x >= 9.75f) // xóa nếu ra khỏi camera
        {
            Destroy(this.gameObject);
        }
    }
}
