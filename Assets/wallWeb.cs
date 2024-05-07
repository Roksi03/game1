using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallWeb : MonoBehaviour
{
    [SerializeField] private GameObject web;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Instantiate(web, transform.position, Quaternion.identity);
        }
    }
}
