using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextBoxManager : MonoBehaviour
{
    public GameObject textBox;
    public TextMeshProUGUI theTextMeshPro;
    // Start is called before the first frame update
    public TextAsset textfile;
    public string[] textLines;

    public int currentLine;
    public int endAtline;
    public PlayerControl player;

    public bool isActive;

    void Start()
    {
        player = FindObjectOfType<PlayerControl>();
        if (textfile != null)
        {
            textLines = (textfile.text.Split('\n'));
        }
        if(endAtline == 0)
        {
            endAtline = textLines.Length - 1;
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
            return;
        }
        theTextMeshPro.text = textLines[currentLine];

        if (Input.GetKeyDown(KeyCode.Return))
        {
            currentLine += 1;
        }

        if(currentLine > endAtline)
        {
            DisableTextBox();
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
            textLines = new string[1];
            textLines = (theTextMeshPro.text.Split('\n'));
        }
    }
}
