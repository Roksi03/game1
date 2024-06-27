using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class flyNew : MonoBehaviour
{
    private Animator flyAnimator; // Reference to the fly's Animator
    private Rigidbody2D flyRigidbody; // Reference to the fly's Rigidbody2D
    public string webbedFlyBool = "flyCatch"; // The boolean parameter to change the fly animation
    public float fallSpeed = 1.0f; // The speed at which the fly falls downwards
   

    private bool isWebbed = false; // Flag to check if the fly is webbed

    void Start()
    {
        // Get the Animator component attached to the fly
        flyAnimator = GetComponent<Animator>();

        if (flyAnimator == null)
        {
            Debug.LogError("Animator is not found on the fly object.");
        }

        // Get the Rigidbody2D component attached to the fly
        flyRigidbody = GetComponent<Rigidbody2D>();

        if (flyRigidbody == null)
        {
            Debug.LogError("Rigidbody2D is not found on the fly object.");
        }

      
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collided object has the tag "throwWeb"
        if (collision.gameObject.CompareTag("throwWeb"))
        {
            // Set the boolean parameter to true to change the fly animation
            if (flyAnimator != null)
            {
                flyAnimator.SetBool(webbedFlyBool, true);
            }

            // Change the fly's velocity to make it fall slowly downwards
            if (flyRigidbody != null)
            {
                flyRigidbody.velocity = new Vector2(0, -fallSpeed);
            }

            isWebbed = true; // Set the flag to true indicating the fly is webbed

            // Optionally, you can destroy the throwWeb object after the collision
            Destroy(collision.gameObject);
        }

        // Check if the collided object has the tag "Ground" and if the fly is webbed
        if (collision.gameObject.CompareTag("Ground") && isWebbed)
        {
            // Stop the fly's movement by setting the velocity to zero
            if (flyRigidbody != null)
            {
                flyRigidbody.velocity = Vector2.zero;
                flyRigidbody.freezeRotation = true;
            }

            isWebbed = false; // Reset the flag
        }

       
    }
}
