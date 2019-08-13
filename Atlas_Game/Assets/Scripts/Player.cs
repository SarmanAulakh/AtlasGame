using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 4.0f;
    private float jumpForce = 2.0f;

    bool isGrounded;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("ground"))
        {
            isGrounded = true;
            rb.velocity = Vector2.zero;
        }
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);
        Jump();  
    }

    void Jump()
    {
        if (Input.anyKey && isGrounded)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jumpForce));
            isGrounded = false;
        }
    }
}
