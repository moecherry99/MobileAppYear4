using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProteinScript : MonoBehaviour
{

    public static int proteinValue;
    Text protein;
    // Start is called before the first frame update
    void Start()
    {
        protein = GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        protein.text = "Protein Shakes : " + proteinValue;
    }
}
