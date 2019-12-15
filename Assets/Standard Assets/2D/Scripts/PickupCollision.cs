using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupCollision : MonoBehaviour
{
    public AudioClip noise1;
    public AudioSource noise;

    // radiate noise from Protein pickups
    void Start()
    {
        noise = GetComponent<AudioSource>();
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        // destroy Protein and add 1 to counter
        if (other.name == "Player")
        {
            noise.PlayOneShot (noise1);
            ProteinScript.proteinValue += 1;
            Destroy(gameObject);
             
        }
    }


}
