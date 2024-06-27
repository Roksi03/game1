using UnityEngine;
using System.Collections;

public class LeverSound : MonoBehaviour
{
    public AudioClip leverSound; // Drag and drop your sound clip in the inspector
    private AudioSource audioSource;

    void Start()
    {
        // Get the AudioSource component attached to the lever object
        audioSource = GetComponent<AudioSource>();

        if (audioSource == null)
        {
            Debug.LogError("AudioSource component missing from this GameObject.");
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the colliding object is the throwWeb
        if (collision.gameObject.CompareTag("throwWeb"))
        {
            Debug.Log("throwWeb triggered the lever"); // Debug message to confirm collision detection
            StartCoroutine(PlaySoundWithDelay(0.3f)); // Start the coroutine to play the sound with a 2-second delay
        }
    }

    private IEnumerator PlaySoundWithDelay(float delay)
    {
        yield return new WaitForSeconds(delay); // Wait for the specified delay

        if (audioSource != null && leverSound != null)
        {
            Debug.Log("Playing sound"); // Debug message to confirm sound is about to play
            audioSource.PlayOneShot(leverSound);
        }
        else
        {
            Debug.LogError("Missing audio source or lever sound clip.");
        }
    }
}