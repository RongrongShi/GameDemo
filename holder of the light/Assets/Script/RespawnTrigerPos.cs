using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnTrigerPos : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 targetPosition = new Vector3(-12.4329f, 5.42f, 312.5446f);
    // Update is called once per frame
    void Update()
    {
        transform.position = targetPosition;
    }
}
