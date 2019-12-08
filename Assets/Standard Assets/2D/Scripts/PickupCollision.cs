using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupCollision : MonoBehaviour
{
    public AudioClip noise1;
    public AudioSource noise;
    void Start()
    {
        noise = GetComponent<AudioSource>();
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.name == "Player")
        {
            noise.PlayOneShot (noise1);
            ProteinScript.proteinValue += 1;
            Destroy(gameObject);
             
        }
    }


}
