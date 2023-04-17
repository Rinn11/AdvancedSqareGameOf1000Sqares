using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundColorChanger : MonoBehaviour
{
    //varubles  
    public Color newBackgroundColor;

    void OnTriggerEnter2D(Collider2D other)
    {
        // checks if coliding with player
        if (other.CompareTag("Player"))
        {
            //set camera background color to green (set in insepecter)
            Camera.main.backgroundColor = newBackgroundColor;
        }
    }
}
