using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class authorscollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("wdjknwaj");
        if (collision.CompareTag("throwWeb"))
        {
            SceneManager.LoadScene("authors");
        }
    }
}
