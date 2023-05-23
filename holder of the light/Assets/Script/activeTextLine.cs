using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activeTextLine : MonoBehaviour
{
    public TextAsset theText;

    public int startLine;
    public int endLine;
    public TextBoxManager theTextBox;
    public bool destroy; // Of het object moet worden vernietigd na het activeren van de dialoog

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
            theTextBox.ReloadScript(theText); // Laad de opgegeven tekst in de TextBoxManager
            theTextBox.currentLine = startLine;
            theTextBox.endAtline = endLine;
            theTextBox.EnableTextBox(); // Activeer de dialoog
        }
        if (destroy)
        {
            Destroy(gameObject); // Vernietig het object als 'destroy' is ingesteld op true
        }
    }
}
