using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global : MonoBehaviour
{

    public static Global Instance = null; // Statische referentie naar de Global instantie
    public float playerPosX = 0.0f, playerPosY = 0.0f, playerPosZ = 0.0f;

    private void Start()
    {
       if (Instance != null)
        {
            Destroy(this); // Vernietig dit object als er al een Global instantie bestaat
            return;
        }
        Instance = this; // Wijs deze instantie toe aan de statische  eferentie
        DontDestroyOnLoad(this); // Zorg ervoor dat dit object niet wordt vernietigd bij het laden van nieuwe scenes
        playerPosX = PlayerPrefs.GetFloat("playPosX");
        playerPosY = PlayerPrefs.GetFloat("playPosY");
        playerPosZ = PlayerPrefs.GetFloat("playPosZ");

        // Controleer of er een opgeslagen positie is en pas de positie van dit object aan
        if (playerPosX != 0.0f)
        {
            gameObject.transform.position = new Vector3(playerPosX, playerPosY, playerPosZ);
        }
    }


}

