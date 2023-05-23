using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RTLmovingPlatform : MonoBehaviour
{
    private float speed = 4f; //snelheid
    private Vector3 dir = Vector3.left; // Richting van de beweging, standaard naar links

    //Your Update function
    void Update()
    {
        transform.Translate(dir * speed * Time.deltaTime);
        // Controleer of het platform de linker grens heeft bereikt (-15)
        if (transform.position.x <= -15)
        {
            dir = Vector3.right;// Verander de richting naar rechts
        }
        else if (transform.position.x >= 5)
        {
            dir = Vector3.left;
        }
    }
}
