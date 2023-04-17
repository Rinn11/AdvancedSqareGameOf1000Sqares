using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakable : MonoBehaviour
{
    //varubles for varuble things (gets the game object and force to break wall
    public float breakForce = 10.0f;
    public GameObject brokenObject;

    void OnCollisionEnter2D(Collision2D collision)
    {
        // checks if the wall has been hit with enough force
        if (collision.relativeVelocity.magnitude > breakForce)
        {
            Destroy(gameObject);
        }
    }
}
