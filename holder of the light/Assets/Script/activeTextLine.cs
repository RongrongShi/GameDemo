using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activeTextLine : MonoBehaviour
{
    public TextAsset theText;

    public int startLine;
    public int endLine;
    public TextBoxManager theTextBox;
    public bool destroy;
    // Start is called before the first frame update
    void Start()
    {
        theTextBox = FindObjectOfType<TextBoxManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider collision)
    {
        if(collision.tag == "Player")
        {
            theTextBox.ReloadScript(theText);
            theTextBox.currentLine = startLine;
            theTextBox.endAtline = endLine;
            theTextBox.EnableTextBox();
        }
        if (destroy)
        {
            Destroy(gameObject);
        }
    }
}
