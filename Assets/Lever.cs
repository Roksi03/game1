using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private Animator animatorDoor;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("throwWeb"))
        {
            animator.SetBool("isPulled", true);
            animatorDoor.SetBool("goesUp", true) ;
        }
        
    }
}