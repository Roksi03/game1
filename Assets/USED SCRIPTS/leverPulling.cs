using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leverPulling : MonoBehaviour
{
    public GameObject lever; // Reference to the lever GameObject
    private Animator leverAnimator; // Animator component for the lever
    private int pullCount; // Counter to keep track of lever pulls

    public GameObject door1; // Reference to the first door GameObject
    public GameObject door2; // Reference to the second door GameObject
    private Animator door1Animator; // Animator component for the first door
    private Animator door2Animator; // Animator component for the second door

    void Start()
    {
        // Get the Animator component from the lever GameObject
        leverAnimator = lever.GetComponent<Animator>();
        pullCount = 0;

        door1Animator = door1.GetComponent<Animator>();
        door2Animator = door2.GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("throwWeb")) // Change "Player" to the tag of the object you want to interact with the lever
        {
            ToggleLever();
        }
    }

    void ToggleLever()
    {
        // Increment the pull count
        pullCount++;

        // Perform action based on whether the pull count is odd or even
        if (pullCount % 2 == 1)
        {
            ActionOne();
            leverAnimator.SetBool("isPulled", true);
        }
        else
        {
            ActionTwo();
            leverAnimator.SetBool("isPulled", false);
        }
    }

    void ActionOne()
    {
        door1Animator.SetBool("Activate", false);
        door2Animator.SetBool("Activate", false);

        Debug.Log("Action One triggered!");
    }

    void ActionTwo()
    {
        door1Animator.SetBool("Activate", true);
        door2Animator.SetBool("Activate", true);

        Debug.Log("Action Two triggered!");
    }
}