using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundColorChanger : MonoBehaviour
{
    public Color newBackgroundColor;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Camera.main.backgroundColor = newBackgroundColor;
        }
    }
}
