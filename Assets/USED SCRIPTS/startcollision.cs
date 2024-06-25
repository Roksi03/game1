using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startcollision : MonoBehaviour
{

   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("wdjknwaj");
        if (collision.CompareTag("throwWeb"))
        {
            SceneManager.LoadScene("tutorial1");
        }
    }
}


