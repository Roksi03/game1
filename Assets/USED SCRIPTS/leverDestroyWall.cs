using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leverDestroyWall : MonoBehaviour
{

    [SerializeField] private Animator animator;
    public GameObject obstacle;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("throwWeb"))
        {
            animator.SetBool("isPulled", true);
            Destroy(other.gameObject); // Optionally destroy the web after it hits the lever
            Invoke("DestroyObstacle", 1f);
        }

    }
    private void DestroyObstacle()
    {
        if (obstacle != null)
        {
            Destroy(obstacle);
        }
    }

}
