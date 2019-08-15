﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    static public Player S;

    private float speed = 4.0f;
    private Vector3 jump;
    private float jumpForce = 2.5f;
    bool isGrounded;
    Rigidbody2D rb;
    public AudioSource jumpSound;

    public Main sn;
 
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jump = new Vector3(0.0f, 4.0f, 0.0f);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("ground"))
        {
            isGrounded = true;
        }
        if (other.gameObject.CompareTag("thunder"))
        {
            Debug.Log("you're fried");
            Destroy(this.gameObject);
            sn.GameOver();
        }

        if (other.gameObject.CompareTag("coin"))
        {
            sn.YouWin();
        }
            
    }

    // Update is called once per frame
    void Update()
    {
        
        rb.velocity = new Vector2(speed, rb.velocity.y);

        if (Input.GetKeyDown("space") && isGrounded)
        {
            jumpSound.Play();
            rb.AddForce(jump * jumpForce, ForceMode2D.Impulse);
            isGrounded = false;

        }
    }

}
