using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateWallWeb : MonoBehaviour
{
    public GameObject webWall;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            webWall.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            webWall.SetActive(false);
        }
    }
}
