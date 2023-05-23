using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;

    void OnTriggerEnter(Collider player)
    {
        // Wanneer de speler de trigger aanraakt, verplaats de speler naar het respawn punt
        player.transform.position = respawnPoint.transform.position;
    }
}
