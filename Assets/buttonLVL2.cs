using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonLVL2 : MonoBehaviour
{
    private bool isOnButton = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Button"))
        {
            isOnButton = true;
            ButtonController button = other.GetComponent<ButtonController>();
            button.ActivateButton(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Button"))
        {
            isOnButton = false;
            ButtonController button = other.GetComponent<ButtonController>();
            button.ActivateButton(false);
        }
    }
}