using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    public Animator animator;
    // float
    float horizontalMove = 0f;

    public float runSpeed = 40;

    bool jump = false;
    bool attack = false;


    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        // Absolute makes value positive
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        // Jump 
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("isJumping", true);
        }

        // Did not use as trigger, needs another input to disable
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            attack = true;
            animator.SetBool("Attacking", true);
            
        }

        // Messy as this requires movement to cancel attack animation
        if (Input.GetKeyDown(KeyCode.W))
        {
            attack = false;
            animator.SetBool("Attacking", false);
          
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            attack = false;
            animator.SetBool("Attacking", false);
            
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            attack = false;
            animator.SetBool("Attacking", false);

        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            attack = false;
            animator.SetBool("Attacking", false);

        }

    }

    // End jump animation
    public void OnLanding()
    {
        animator.SetBool("isJumping", false);
        
    }

    // After fixed time, jump ends
    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
        

    }
}
