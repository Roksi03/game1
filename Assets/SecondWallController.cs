using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondWallController : MonoBehaviour
{
    private Animator animator;
    private bool isObjectActive;

    private void Start()
    {
        animator = GetComponent<Animator>();
        isObjectActive = false;
    }

    public void SetObjectState(bool isActive)
    {
        if (isActive && !isObjectActive)
        {
            animator.SetTrigger("Activate");
            isObjectActive = true;
        }
    }
}
