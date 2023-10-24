using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5.0f; // Adjust this to control the player's movement speed

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput);
        movement.Normalize(); // Ensures diagonal movement isn't faster

        // Move the player
        transform.Translate(movement * speed * Time.deltaTime);
        transform.Translate(new Vector3(0, 1, 0));
    }
}
