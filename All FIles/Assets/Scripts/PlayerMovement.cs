using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb; 
    public float MoveSpeed = 15f;
    public bool Jumping = true;
    public bool IsGrounded = true; 
    int JumpCount = 0;
    public int JumpRestrictions = 2;
    


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float dirX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(dirX * MoveSpeed, rb.velocity.y);



        if (Input.GetButtonDown("Jump") && Jumping == true && IsGrounded == true)
        {
            Jump();
        }

        //double jumping code
        //tracks the number of times the player jumps and compares it to the number of times it is allowed to jump
        if (Input.GetButtonDown("Jump") && JumpCount < JumpRestrictions)
        {
            Jumping = true;
        }

        if (Input.GetButtonDown("Jump") && JumpCount == JumpRestrictions)
        {
            Jumping = false;
            IsGrounded = false;
            JumpCount = 0;
            Debug.Log(JumpCount);
        }
    }

        void Jump()
        {
            rb.velocity = new Vector2(rb.velocity.x, MoveSpeed);
            JumpCount += 1;
            Debug.Log(JumpCount);

        }

        void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Ground"))
            {
                IsGrounded = true;
                Jumping = true;
            }
        
        }
}
