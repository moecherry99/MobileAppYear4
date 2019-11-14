
using System;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public Main main;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            main.CompleteLevel();
        }
    }

 
}
