using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public float speed;

    private Animator anim;
    public Animator animator;

    private void Update()
    {
        // if speed is greater than 0, use walk animation
        if (speed < 0)
        {
            animator.SetBool("Walk", true);
        }

       

        // destroys enemy if health is 0
        if (health <= 0)
        {
            Debug.Log("Killed Enemy");
            Destroy(gameObject);
        }
    }

    private void HandleMovement(bool horizontal)
    {
        // attempt at flipping sprite
        if(speed > 0)
        {
            horizontal = true;
        }
    }

    public void TakeDamage(int damage)
    {
        // damage debug log
        health -= damage;
        if (health <= 1)
        {
            Debug.Log("damage taken " + damage);
        }
    }

  

}
