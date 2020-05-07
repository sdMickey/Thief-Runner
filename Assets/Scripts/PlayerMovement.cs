using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;



public class PlayerMovement : MonoBehaviour
{
    public GameM gamem;
    public float jump = 50f;
    bool onGround = false;
    public Rigidbody2D rb;

    public int score = 0;
    public Text scoreText, highScoreText;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        highScoreText.text = "HIGH SCORE: " + PlayerPrefs.GetInt("HIGHSCORE").ToString();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        score++;
        scoreText.text = "SCORE: " + score.ToString();
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
            OnGameOver();
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

    private void OnGameOver()
    {
        var highScore = PlayerPrefs.GetInt("HIGHSCORE");
        highScore = score > highScore ? score : highScore;
        PlayerPrefs.SetInt("HIGHSCORE", highScore);
    }



}
