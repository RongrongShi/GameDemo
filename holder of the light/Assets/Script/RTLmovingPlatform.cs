using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RTLmovingPlatform : MonoBehaviour
{
    private float speed = 4f;
    private Vector3 dir = Vector3.left;

    //Your Update function
    void Update()
    {
        transform.Translate(dir * speed * Time.deltaTime);

        if (transform.position.x <= -15)
        {
            dir = Vector3.right;
        }
        else if (transform.position.x >= 5)
        {
            dir = Vector3.left;
        }
    }
}
