using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public float speed;

    private Animator anim;

    private void Start()
    {
        
    }

    private void Update()
    {
        if(health <= 0)
        {
            Debug.Log("Killed Enemy");
            Destroy(gameObject);
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
