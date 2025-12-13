using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MOVEMENT : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 7f;
    public LayerMask groundLayer;
    public Transform groundCheck;
    public float groundCheckRadius = 0.2f;
    public GameObject jump;
    public GameObject speed;
    public Boolean jumpA;
    public Boolean jumpB;
    public Boolean speedA;
    public Boolean speedB;
    //ublic Boolean A;
    public float x;
    public float y;

    private Rigidbody2D rb;
    private float moveInput;
    private bool isGrounded;

    void Start()
    {
        x = 9999f;
        y = 9999f;
        rb = GetComponent<Rigidbody2D>();
        jumpA = false;
        jumpB = false;
        speedA = false;
        speedB = false;
     // A = false;
    }

    void Update()
    {
        moveInput = Input.GetAxisRaw("Horizontal");

        // Flip sprite
        if (moveInput > 0)
        {
            transform.localScale = new Vector3(1, transform.localScale.y, transform.localScale.z);
        }
        else if (moveInput < 0)
        {
            transform.localScale = new Vector3(-1, transform.localScale.y, transform.localScale.z);
        }

        // Jumping
        if ((Input.GetKeyDown(KeyCode.W) || (Input.GetKeyDown(KeyCode.UpArrow))) && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

        //if ((Input.GetKeyDown(KeyCode.Space))
            
        

        // Ground check
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        if ((transform.position.x >= x - 2f && transform.position.x <= x + 2f) && (transform.position.y >= y - 2f && transform.position.y <= y + 2f))
        {
            if (jumpA == true)
            {
                jumpB = true;
            }

            if (speedA == true)
            {
                speedB = true;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "flag")
        {
            x = transform.position.x;
            y = transform.position.y;
            if (jumpA == true)
            {
                jumpB = true;
            }

            if (speedA == true)
            {
                speedB = true;
            }
        }
        if (collision.tag == "flag1")
        {
            x = transform.position.x;
            y = transform.position.y;
            if (jumpA == true)
            {
                jumpB = true;
            }

            if (speedA == true)
            {
                speedB = true;
            }
        }
        if (collision.tag == "flag2")
        {
            x = transform.position.x;
            y = transform.position.y;
            if (jumpA == true)
            {
                jumpB = true;
            }

            if (speedA == true)
            {
                speedB = true;
            }
        }
        if (collision.tag == "flag3")
        {
            x = transform.position.x;
            y = transform.position.y;
            if (jumpA == true)
            {
                jumpB = true;
            }

            if (speedA == true)
            {
                speedB = true;
            }
        }
        if (collision.tag == "flag4")
        {
            x = transform.position.x;
            y = transform.position.y;
            if (jumpA == true)
            {
                jumpB = true;
            }

            if (speedA == true)
            {
                speedB = true;
            }
        }

        if (collision.tag == "lava")
        {
            if (jumpB == false)
            {
                jumpA = false;
                jumpForce = 12;
                jump.SetActive(true);
            }

            if (speedB == false)
            {
                speedA = false;
                moveSpeed = 5;
                speed.SetActive(true);
            }
        }

        if (collision.tag == "jump")
        {
            jump.SetActive(false);
            jumpForce = 20;
            jumpA = true;
        }

        if (collision.tag == "speed")
        {
            speed.SetActive(false);
            moveSpeed = 10;
            speedA = true;
        }

        if (collision.tag == "speedUp")
        {
            moveSpeed = 10;
        }

        if (collision.tag == "slowDown")
        {
            moveSpeed = 5;
        }
    }

    void FixedUpdate()
    {
        // Apply horizontal movement
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);
    }
}
