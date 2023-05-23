using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LTRmovingPlatform : MonoBehaviour
{
    private float speed = 5f;
    private Vector3 dir = Vector3.left; // Richting van de beweging

    //Your Update function
    void Update()
    {
        // Beweeg het platform in de opgegeven richting met de opgegeven snelheid
        transform.Translate(dir * speed * Time.deltaTime);

        if (transform.position.x <= -15)
        {
            // Verander de richting naar rechts
            dir = Vector3.right;
        }
        else if (transform.position.x >= 4)
        {
            dir = Vector3.left;
        }
    }
}
