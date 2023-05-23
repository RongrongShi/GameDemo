using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text : MonoBehaviour
{
    // Start is called before the first frame update
    public TextAsset textfile; // Tekstbestand dat wordt geladen
    public string[] textLines; // Array om de tekstregels op te slaan
    void Start()
    {
        if (textfile != null)
        {
            textLines = (textfile.text.Split('\n')); // Scheid de tekst in regels en sla ze op in de array
        }
    }

    // Update is called once per frame
   
}
