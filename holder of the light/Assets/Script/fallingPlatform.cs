using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingPlatform : MonoBehaviour
{
    bool isFalling = false;
    float downSpeed = 0;

    private void OnTriggerEnter(Collider collider)
    {
        if(collider .gameObject.name == "player")
        {
            isFalling = true;
            Destroy(gameObject, 2);
        }
    }
    void Update()
    {
        if (isFalling)
        {
            downSpeed += Time.deltaTime / 60;
            transform.position = new Vector3(transform.position.x, transform.position.y - downSpeed, transform.position.z);
        }
    }
}
