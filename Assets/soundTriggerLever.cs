using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundTriggerLever : MonoBehaviour
{
    public AudioClip triggerSound;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (triggerSound != null)
        {
            audioSource.PlayOneShot(triggerSound, 1f);
        }
    }
}
