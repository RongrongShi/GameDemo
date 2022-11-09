using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingPlatform : MonoBehaviour
{
    bool isFalling = false;
    float downSpeed = 0;
    GameObject FallingPlatform;
    private float timer = 0;

    private void OnTriggerEnter(Collider collider)
    {
        if(collider .gameObject.name == "player")
        {
            isFalling = true;
            Destroy(gameObject, 2);
        }
    }
    void Start()
    {
        FallingPlatform = GameObject.Find("fallingPlatform");
    }
    void Update()
    {
        if (isFalling)
        {
            downSpeed += Time.deltaTime / 60;
            transform.position = new Vector3(transform.position.x, transform.position.y - downSpeed, transform.position.z);
        }
       /*if (isFalling != false && timer == 0.5f)
        {
            Destroy(gameObject);
            Debug.Log("isTrue");
        }*/
    }
}
