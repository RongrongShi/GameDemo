using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject objectToFollow;
    public float speed = 2.0f;
    public Vector3 offset = new Vector3(0, 5, -6);

    void Update()
    {
        this.transform.position = Vector3.Lerp(this.transform.position, objectToFollow.transform.position + offset, speed + Time.deltaTime);
    }
}