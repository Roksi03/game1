using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leverLVL2 : MonoBehaviour
{
    public GameObject door1; // Reference to the first door GameObject
    public GameObject door2; // Reference to the second door GameObject
    private Animator door1Animator; // Animator component for the first door
    private Animator door2Animator; // Animator component for the second door
    private bool isPulled; // State of the lever

    void Start()
    {
        // Get the Animator components from the door GameObjects
        door1Animator = door1.GetComponent<Animator>();
        door2Animator = door2.GetComponent<Animator>();
        isPulled = false;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("throwWeb")) // Change "Player" to the tag of the object you want to interact with the lever
        {
            ToggleDoors();
        }
    }

    void ToggleDoors()
    {
        if (isPulled)
        {
            // Open door1 and close door2
            door1Animator.SetBool("isOpen", true);
            door2Animator.SetBool("isOpen", false);
        }
        else
        {
            // Close door1 and open door2
            door1Animator.SetBool("isOpen", false);
            door2Animator.SetBool("isOpen", true);
        }

        // Toggle the state
        isPulled = !isPulled;
    }
}