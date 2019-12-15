using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProteinScript : MonoBehaviour
{

    public static int proteinValue;
    Text protein;
    
    // protein text
    void Start()
    {
        protein = GetComponent<Text> ();
    }

    // Protein shake counter
    void Update()
    {
        protein.text = "Protein Shakes : " + proteinValue;
    }
}
