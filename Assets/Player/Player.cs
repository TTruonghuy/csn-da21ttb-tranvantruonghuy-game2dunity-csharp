using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jump = 500;
    private bool isGrounded;
    public Animator anim;
    public void Jumppum()
    {
        if (isGrounded)
        {
            rb.AddForce(Vector2.up * jump);
        }
    }
    private void OnCollisionEnter2D(Collision2D other) // xử lý animation
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            anim.SetBool("nhay", false);
        }
    }
    private void OnCollisionExit2D(Collision2D other) // xử lý animation
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
            anim.SetBool("nhay", true);
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector2.up * jump);
        }
    }
    private void OnTriggerEnter2D(Collider2D other) // xu ly va cham
    {
        if (other.CompareTag("Box"))
        {
            SceneManager.LoadScene("Die");
        }
        if (other.CompareTag("Pteranodon"))
        {
            SceneManager.LoadScene("Die");
        }
    }

}
  

   


