using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeverAuthors : MonoBehaviour
{
    [SerializeField] private Animator animator;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("throwWeb"))
        {
            animator.SetBool("isPulled", true);
            StartCoroutine(Authors());

        }

    }
    IEnumerator Authors()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("authors");
    }

}
