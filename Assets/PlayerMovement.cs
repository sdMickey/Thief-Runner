using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;



public class PlayerMovement : MonoBehaviour
{
    public GameM gamem;
    public float jump = 50f;
    bool onGround = false;
    public Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }




    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && onGround)
        {
            rb.velocity = Vector2.up * jump;
        }
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            onGround = true;
        }

        if (collision.collider.tag == "brick")
        {
            gamem.GameOver();
        }
        
    }



    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            onGround = true;
        }
    }



    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            onGround = false;
        }
    }



}
