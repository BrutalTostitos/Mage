using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    //Public variables
    public bool mFacingRight = true;
    public float mSpeed;
    public float jumpForce;
    public Vector2 moveInput;   // = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

    //Will be used for gravity
    public bool isGrounded = true;


    //private variables
    private Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        
    }

    //manages anything dealing with physics
    private void FixedUpdate()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");
        rb.velocity = moveInput * mSpeed;
        
        if (mFacingRight == false && moveInput.x > 0)
        {
            Flip();
        }
        if (mFacingRight == true && moveInput.x < 0)
        {
            Flip();
        }

    }






    private void Flip()
    {
        // Switch the way the player is labelled as facing.
        mFacingRight = !mFacingRight;

        // Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}