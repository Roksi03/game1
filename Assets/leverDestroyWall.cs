using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leverDestroyWall : MonoBehaviour
{
    public GameObject obstacle; // Reference to the wall GameObject

    [SerializeField] private Animator animator;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("throwWeb"))
        {
            animator.SetBool("isPulled", true);
            DestroyWall();
        }

    }

    private void DestroyWall()
    {
        if (obstacle != null)
        {
            Destroy(obstacle);
        }
    }
}
