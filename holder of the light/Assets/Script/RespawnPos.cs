using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPos : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 targetPosition = new Vector3(-12.4329f, 5.42f, 312.5446f); // terrain pos

    void Update()
    {
        transform.position = targetPosition;
    }
}
