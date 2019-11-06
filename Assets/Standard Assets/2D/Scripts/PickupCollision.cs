﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupCollision : MonoBehaviour
{
    void Collider2D(Collider collider)
    {
        if(collider.gameObject.CompareTag("Protein"))
        {
            Destroy(collider.gameObject);
        }
    }
}
