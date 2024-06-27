using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly2 : MonoBehaviour
{
    private Animator flyAnimator; // Reference to the fly's Animator
    public string flyAnimationTrigger = "FlyAnimation"; // The trigger to start the fly animation

    void Start()
    {
        // Get the Animator component attached to the fly
        flyAnimator = GetComponent<Animator>();

        if (flyAnimator == null)
        {
            Debug.LogError("Animator is not found on the fly object.");
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collided object has the tag "throwWeb"
        if (collision.gameObject.CompareTag("throwWeb"))
        {
            // Play the fly animation
            if (flyAnimator != null)
            {
                flyAnimator.SetTrigger(flyAnimationTrigger);
            }

            // Make the throwWeb object disappear
            Destroy(collision.gameObject);
        }
    }
}
