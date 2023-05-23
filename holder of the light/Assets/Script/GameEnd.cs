using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnd : MonoBehaviour
{
    public static bool isGameOver;
    public GameObject gameOverScreen; 
    private void Awake()
    {
        isGameOver = false;
    }
    // Start is called before the first frame update
    void Update()
    {
        if (isGameOver)
        {
            gameOverScreen.SetActive(true);
            Time.timeScale = 0f;  // stop player move
        }
    }
    public void QuitGame()
    {
        Application.Quit();
        //Debug.Log("quit");
    }

}
