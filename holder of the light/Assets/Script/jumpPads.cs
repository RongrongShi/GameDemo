using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpPads : MonoBehaviour
{
    [Range(100, 10000)]
    public float bouncehight; // Hoogte van de stuitersprong

    private void OnCollisionEnter(Collision collision)
    {
        GameObject bouncer = collision.gameObject; // Het object dat de stuitersprong maakt
        Rigidbody rb = bouncer.GetComponent<Rigidbody>(); // Rigidbody-component van het object
        rb.AddForce(Vector3.up * bouncehight); // Voeg een kracht toe die het object omhoog stuwt
    }
}

