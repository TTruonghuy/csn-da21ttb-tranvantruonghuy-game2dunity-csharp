using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_Box : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) //kiểm tra xem có va chạm với Game Objcet có tag là Player
        {
            Destroy(this.gameObject); // nếu chạm thì xóa 
        }
    }
}
