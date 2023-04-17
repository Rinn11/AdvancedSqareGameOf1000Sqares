using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakable : MonoBehaviour
{
    public float breakForce = 10.0f;
    public GameObject brokenObject;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.magnitude > breakForce)
        {
            Destroy(gameObject);
        }
    }
}
