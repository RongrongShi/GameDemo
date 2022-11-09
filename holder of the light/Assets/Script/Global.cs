using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global : MonoBehaviour
{

    public static Global Instance = null;
    public float playerPosX = 0.0f, playerPosY = 0.0f, playerPosZ = 0.0f;

    private void Start()
    {
       if (Instance != null)
        {
            Destroy(this);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(this);
        playerPosX = PlayerPrefs.GetFloat("playPosX");
        playerPosY = PlayerPrefs.GetFloat("playPosY");
        playerPosZ = PlayerPrefs.GetFloat("playPosZ");

        if (playerPosX != 0.0f)
        {
            gameObject.transform.position = new Vector3(playerPosX, playerPosY, playerPosZ);
        }
    }


}

