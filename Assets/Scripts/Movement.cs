using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float jumpSpeed = 3;
    public float moveSpeed = 2;

    Rigidbody2D rb2D;
    SpriteRenderer spriteRenderer;
    Animator animator;

    //better jump
    public bool betterJump = false;
    public float fallMultiplier = 0.5f;
    public float lowJumpMultiplier = 1f;


    
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Left-Right Movement
        if (Input.GetKey("d"))
        {
            rb2D.velocity = new Vector2 (moveSpeed, rb2D.velocity.y);
            spriteRenderer.flipX = false;
            animator.SetBool("Run", true);
        }
        else if (Input.GetKey("a"))
        {
            rb2D.velocity = new Vector2(-moveSpeed, rb2D.velocity.y);
            spriteRenderer.flipX = true;
            animator.SetBool("Run", true);
        }
        else
        {
            rb2D.velocity = new Vector2(0, rb2D.velocity.y);
            animator.SetBool("Run", false);
        }

        //Jump
        if (Input.GetKeyDown("space") && CheckGround.isGrounded)
        {
            rb2D.velocity = new Vector2(rb2D.velocity.x, jumpSpeed);
         
        }

        if(CheckGround.isGrounded == false)
        {
            animator.SetBool("Jump", true);
            animator.SetBool("Run", false);

        }
        if(CheckGround.isGrounded == true)
        {
            animator.SetBool("Jump", false);
            animator.SetBool("Fall", false);
        }

        if(rb2D.velocity.y < 0)
        {
            animator.SetBool("Fall", true);
        }
        else if(rb2D.velocity.y > 0)
        {
            animator.SetBool("Fall",false);
        }

        if(betterJump)
        {
            if(rb2D.velocity.y < 0)
            {
                rb2D.velocity += Vector2.up * Physics.gravity.y * (fallMultiplier) * Time.deltaTime;
            }
            if (rb2D.velocity.y > 0 && !Input.GetKey("space"))
            {
                rb2D.velocity += Vector2.up * Physics.gravity.y * (lowJumpMultiplier) * Time.deltaTime;
            }
        }
    }
}
