using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leverSound : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("throwWeb"))
        {
            if (audioSource != null)
            {
                audioSource.Play();
            }
        }
    }
}
