using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public Animator wall1Animator;
    public Animator wall2Animator;

    private Vector3 wall1InitialPosition;

    private bool isPlayerOnButton = false;

    private void Start()
    {
        wall1InitialPosition = wall1Animator.transform.position;
    }

    private void Update()
    {
        if (!isPlayerOnButton)
        {
            // Reset wall1's position when player is not on the button
            wall1Animator.transform.position = wall1InitialPosition;
        }
    }

    public void ActivateButton(bool activate)
    {
        if (activate)
        {
            // Play animations for both walls
            wall1Animator.SetBool("Activate", true);
            wall2Animator.SetBool("Activate", true);
        }
        else
        {
            // Stop animations for both walls
            wall1Animator.SetBool("Activate", false);
            wall2Animator.SetBool("Activate", true);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerOnButton = true;
            ActivateButton(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerOnButton = false;
            ActivateButton(false);
        }
    }
}