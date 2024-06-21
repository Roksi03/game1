using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonScript : MonoBehaviour
{
    public GameObject wall; // Reference to the wall GameObject
    private Animator wallAnimator;
    private bool goesUp;

    void Start()
    {
        // Get the Animator component from the wall GameObject
        wallAnimator = wall.GetComponent<Animator>();
        goesUp = false;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            goesUp = true;
            // Trigger the animation in the wall Animator
            wallAnimator.SetBool("goesUp", true);
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            goesUp = false;
            // Stop the animation in the wall Animator
            wallAnimator.SetBool("goesDown", true);
        }
    }
}
