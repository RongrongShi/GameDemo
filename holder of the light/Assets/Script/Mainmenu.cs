using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
   public void PlayGame()
   {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // klik op de button om het spel te laden/starten
    }
    public void QuitGame()
    {
        Application.Quit();   //klik op de button om het spel te verlaten
    }
}
