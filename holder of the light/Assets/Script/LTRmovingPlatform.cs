using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LTRmovingPlatform : MonoBehaviour
{
    private float speed = 5f;
    private Vector3 dir = Vector3.left;

    //Your Update function
    void Update()
    {
        transform.Translate(dir * speed * Time.deltaTime);

        if (transform.position.x <= -15)
        {
            dir = Vector3.right;
        }
        else if (transform.position.x >= 4)
        {
            dir = Vector3.left;
        }
    }
}
