using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class exit : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
       
        if (other.CompareTag("throwWeb"))
        {
            ExitGame();
            StopPlayMode();
        }
    }

    private void ExitGame()
    {

        Debug.Log("exit");
        Application.Quit();
       
    }
    public void StopPlayMode()
    {
        // Zatrzymanie trybu Play Mode w edytorze Unity
        UnityEditor.EditorApplication.isPlaying = false;
    }

}
