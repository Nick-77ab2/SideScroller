using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;

    private CharacterController rb;
    private bool facingRight = true;
    private float moveDirection;
    private bool isJumping = false;

    private void Awake()
    {
        rb = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get Inputs
        getInputs();

        //Animate
        Animate();

    }

    private void FixedUpdate()
    {
         //Move
        Move();
    }
    //better for handling Physics, can be called multiple times per update frame.
    private void Move()
    {
        Debug.Log("Moving");
        Vector3 movement = new Vector3(moveDirection * moveSpeed, rb.velocity.y,0);
        rb.Move(movement);
        if(isJumping)
        {
            rb.Move(new Vector3(movement[0], jumpForce, 0f));
        }
        isJumping = false;
    }

    private void Animate()
    {
        if (moveDirection > 0 && !facingRight)
        {
            FlipCharacter();
        }
        else if (moveDirection < 0 && facingRight)
        {
            FlipCharacter();
        }
    }

    private void getInputs()
    {
        moveDirection = Input.GetAxis("Horizontal"); // Scale of -1 -> 1
        if(Input.GetButtonDown("Jump"))
        {
            isJumping = true;
        }
    }

    private void FlipCharacter()
    {
        facingRight = !facingRight; //Inverse bool is
        rb.transform.rotation.Set(0f, 180f, 0f, 0f);
    }
    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("I'm hit");
    }
}
