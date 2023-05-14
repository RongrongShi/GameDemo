using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainPos : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 targetPosition = new Vector3(-49.2f, 0f, 268f); // terrain pos

    void Update()
    {
        transform.position = targetPosition; 
    }
}