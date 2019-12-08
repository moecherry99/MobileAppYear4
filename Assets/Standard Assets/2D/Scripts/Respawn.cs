using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// reference - https://www.youtube.com/watch?v=nBgCeJBMT0k
public class Respawn : MonoBehaviour
{

    // for private fields
    [SerializeField] private Transform player;

    [SerializeField] private Transform respawnPoint;
    private void OnTriggerEnter2D(Collider2D other)
    {
        ProteinScript.proteinValue -= 1;
        player.transform.position = respawnPoint.transform.position;
    }
}
