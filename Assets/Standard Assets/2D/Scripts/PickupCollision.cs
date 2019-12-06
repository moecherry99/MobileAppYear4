using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupCollision : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.name == "Player")
        {
            ProteinScript.proteinValue += 1;
            Destroy(gameObject);
             
        }
    }


}
