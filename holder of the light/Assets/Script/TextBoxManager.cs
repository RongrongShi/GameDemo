using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextBoxManager : MonoBehaviour
{
    public GameObject textBox;
    public TextMeshProUGUI theTextMeshPro; // Tekstmeshpro-component
    // Start is called before the first frame update
    public TextAsset textfile;
    public string[] textLines;

    public int currentLine; // Huidige regel in de tekst
    public int endAtline;
    public PlayerControl player;

    public bool isActive; // Geeft aan of de tekstbox actief is

    void Start()
    {
        player = FindObjectOfType<PlayerControl>();
        if (textfile != null)
        {
            textLines = (textfile.text.Split('\n'));
        }
        if(endAtline == 0)
        {
            endAtline = textLines.Length - 1;  // Stel de eindregel in op de laatste regel als deze niet is opgegeven
        }
        if (isActive)
        {
            EnableTextBox();
        }
        else
        {
            DisableTextBox();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!isActive)
        {
            return;       // Als de tekstbox niet actief is, wordt de update-functie vroegtijdig verlaten
        }
        theTextMeshPro.text = textLines[currentLine]; // Toon de tekst van de huidige regel in de TextMeshPro-component


        if (Input.GetKeyDown(KeyCode.Return))
        {
            currentLine += 1;   // Ga naar de volgende regel als de Return-toets wordt ingedrukt
        }

        if(currentLine > endAtline)
        {
            DisableTextBox();     // Deactiveer de tekstbox als de huidige regel de eindregel heeft overschreden
        }
    }
    public void EnableTextBox()
    {
        textBox.SetActive(true);
        isActive = true;
    }
    public void DisableTextBox()
    {
        textBox.SetActive(false);
        isActive = false;

    }
    public void ReloadScript(TextAsset theTextMeshPro)
    {
        if(theTextMeshPro != null)
        {
            textLines = new string[1];  // Maak een nieuwe array met ижижn element
            textLines = (theTextMeshPro.text.Split('\n'));
        }
    }
}
