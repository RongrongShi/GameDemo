using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject objectToFollow;
    public float speed = 2.0f;
    public Vector3 offset = new Vector3(0, 5, -6);

    private void Start()
    {
        // Bereken de nieuwe positie van de camera door de huidige positie naar de positie van het te volgen object te verplaatsen met een offset
        objectToFollow = GameObject.FindWithTag("Player");
    }
    void Update()
    {
        // Gebruik Lerp om geleidelijk naar de nieuwe positie te bewegen met een snelheid bepaald door de variabele "speed"
        this.transform.position = Vector3.Lerp(this.transform.position, objectToFollow.transform.position + offset, speed + Time.deltaTime);
    }
}