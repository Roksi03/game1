using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeverExit : MonoBehaviour
{
    [SerializeField] private Animator animator;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("throwWeb"))
        {
            animator.SetBool("isPulled", true);
            StartCoroutine(Exit());
           
        }
    }

   


        

    
    IEnumerator Exit()
    {
        yield return new WaitForSeconds(2);
        Application.Quit();
    }
}
