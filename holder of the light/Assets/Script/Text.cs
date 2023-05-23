using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text : MonoBehaviour
{
    // Start is called before the first frame update
    public TextAsset textfile;
    public string[] textLines;
    void Start()
    {
        if (textfile != null)
        {
            textLines = (textfile.text.Split('\n'));
        }
    }

    // Update is called once per frame
   
}
