using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
  
    public Scene currentScene;
    public string currentSceneName;
    public bool f;
    public GameObject player;

    void Start()
    {
        currentScene = SceneManager.GetActiveScene();
        currentSceneName = currentScene.name;
        player = GameObject.FindWithTag("Player");
        
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            f = true;
            Debug.Log("F");
        }
        else
        {
            f = false;
        }
        if (currentSceneName == "level2" && f)
        {
            PlayerPrefs.SetFloat("playerPosX", player.transform.position.x);
            PlayerPrefs.SetFloat("playerPosY", player.transform.position.y);
            PlayerPrefs.SetFloat("playerPosZ", player.transform.position.z);
            SceneManager.LoadScene(4, LoadSceneMode.Single);
            //Debug.Log("Collide1");

        }
        else if (currentSceneName == "level2Change" && f)
        {
            PlayerPrefs.SetFloat("playerPosX", player.transform.position.x);
            PlayerPrefs.SetFloat("playerPosY", player.transform.position.y);
            PlayerPrefs.SetFloat("playerPosZ", player.transform.position.z);
            SceneManager.LoadScene(3, LoadSceneMode.Single);
            //Debug.Log("Collide2");

        }
    }


}
