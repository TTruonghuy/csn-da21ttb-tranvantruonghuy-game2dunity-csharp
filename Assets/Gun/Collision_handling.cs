using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision_handling : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Pteranodon")) 
        {                       
            Destroy(this.gameObject);
        }

        if (collision.CompareTag("Box"))
        {
            Destroy(this.gameObject);   
        }
    }
}
