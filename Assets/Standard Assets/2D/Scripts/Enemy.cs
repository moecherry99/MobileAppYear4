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
        if (speed < 0)
        {
            animator.SetBool("Walk", true);
        }

       

        if (health <= 0)
        {
            Debug.Log("Killed Enemy");
            Destroy(gameObject);
        }
    }

    private void HandleMovement(bool horizontal)
    {
        if(speed > 0)
        {
            horizontal = true;
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 1)
        {
            Debug.Log("damage taken " + damage);
        }
    }

  

}
