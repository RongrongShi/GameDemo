using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("1st scene"); // klik op de button om het spel te laden/starten
    }
    public void QuitGame()
    {
        Application.Quit();   //klik op de button om het spel te verlaten
    }
}


