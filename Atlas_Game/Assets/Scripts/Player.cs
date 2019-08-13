using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float speed = 4.0f;
    private Vector2 jump;
    private float jumpForce = 2.5f;
    bool isGrounded;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
<<<<<<< HEAD
        jump = new Vector3(0.0f, 2.0f, 0.0f);
=======
>>>>>>> parent of 8ed24b1... changed camera movement
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("ground"))
        {
            isGrounded = true;
<<<<<<< HEAD
=======
            rb.velocity = Vector2.zero;
>>>>>>> parent of 8ed24b1... changed camera movement
        }
    }

    // Update is called once per frame
    void Update()
    {
        //move horizonatally
        rb.velocity = new Vector2(speed, rb.velocity.y);
<<<<<<< HEAD
=======
        Jump();  
    }
>>>>>>> parent of 8ed24b1... changed camera movement

        //jump
        if (Input.anyKey && isGrounded)
        {
            rb.AddForce(jump * jumpForce, ForceMode2D.Impulse);
            isGrounded = false;
        }
    }

}
