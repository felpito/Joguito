using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class playerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("eae jogo bosta");
    }
    public bool isGrounded = false;
    public Rigidbody2D rb;
    public bool facingRight = true;

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-5, rb.velocity.y);
            FlipRight();
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(5, rb.velocity.y);
            FlipLeft();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Jump();
        }
    }

    void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, 5f);
    }

    void FlipRight()
    {
        if (facingRight == true)
        {
            transform.Rotate(0f, 180f, 0f);
            facingRight = false;
        }
    }
    void FlipLeft()
    {
        if (facingRight == false)
        {
            transform.Rotate(0f, 180f, 0f);
            facingRight = true;
        }
    }
}