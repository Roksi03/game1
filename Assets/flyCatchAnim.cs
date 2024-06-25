using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyCatchAnim : MonoBehaviour
{
    [SerializeField] private Animator animator;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            animator.SetBool("flyCatch", true);
            var rb = GetComponent<Rigidbody2D>();
            rb.bodyType = RigidbodyType2D.Dynamic;
        }

        if (other.gameObject.CompareTag("throwWeb"))
        {
            animator.SetBool("flyCatch", true);
            var rb = GetComponent<Rigidbody2D>();
            rb.bodyType = RigidbodyType2D.Dynamic;
        }
    }
}