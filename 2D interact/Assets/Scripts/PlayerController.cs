using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // wow varubles for player movement
    public float speed = 5.0f;
    public float jumpForce = 10.0f;

    private Rigidbody2D rb;

    void Start()
    {
        // gets rigidbody
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // gets player movement
        float horizontalInput = Input.GetAxis("Horizontal");

        //trans forms the player left or right accourding to input
        transform.Translate(Vector2.right * horizontalInput * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // creates jumpforce in the up direction
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}
