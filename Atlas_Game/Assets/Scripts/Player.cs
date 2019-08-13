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
<<<<<<< HEAD
<<<<<<< HEAD

        jump = new Vector3(0.0f, 2.0f, 0.0f);

=======
>>>>>>> parent of 8ed24b1... changed camera movement
=======
        rb.velocity = new Vector2(speed, 0);
>>>>>>> parent of 76b50f9... Merge branch 'master' of https://github.com/Sarman5432/AtlasGame
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("ground"))
        {
            isGrounded = true;
<<<<<<< HEAD
=======
   
>>>>>>> parent of 76b50f9... Merge branch 'master' of https://github.com/Sarman5432/AtlasGame
            rb.velocity = Vector2.zero;
        }
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);
<<<<<<< HEAD
        Jump();  
<<<<<<< HEAD
=======
    }
>>>>>>> parent of 8ed24b1... changed camera movement
=======
        Jump();
        Debug.Log(isGrounded);
    }
>>>>>>> parent of 76b50f9... Merge branch 'master' of https://github.com/Sarman5432/AtlasGame

    void Jump()
    {
        if (Input.anyKey && isGrounded)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jumpForce));
            isGrounded = false;
        }
    }
}
