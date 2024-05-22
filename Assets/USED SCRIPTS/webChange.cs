using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class webChange : MonoBehaviour
{
    [SerializeField] private GameObject webChanger;
    [SerializeField] private GameObject webChangerTarget;
    public Animator animator; // The Animator component attached to the player sprite
    public string animationTriggerName = "flyCatch"; // The name of the trigger parameter in the Animator

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(webChanger, transform.position, Quaternion.identity);
    }

    void Start()
    {
        if (animator == null)
        {
            animator = GetComponent<Animator>();
        }

        if (animator == null)
        {
            Debug.LogError("Animator component not found on the GameObject.");
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "throwWeb")
        {
            animator.SetTrigger("flyCatch");
        }
    }

}
