using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;  // In andere scripts is het gemakkelijk om te controleren of het spel is gepauzeerd

    public GameObject pauseMenuUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                pause();
            }
        }
    }
     public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;                    //laat het spel niet meer pauzeren
        GameIsPaused = false;
    }

    void pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;                 // game pauzeren
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;             // game kunt normaal worden uitgevoerd wnr het spel is gepauzeerd en terugkeert naar de mainMenu en opnieuw starten
        SceneManager.LoadScene("mainmenu");
    }

    public void QuitGame()
    {
        Application.Quit();
        //Debug.Log("Quit");
    }
}
