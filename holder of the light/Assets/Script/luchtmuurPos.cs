using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class luchtmuurPos : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 targetPosition = new Vector3(-8.42f, 12.03f, 263.71f); // terrain pos

    void Update()
    {
        transform.position = targetPosition;
    }
}
