using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitButton : MonoBehaviour
{
    // This method will be called when the button is clicked
    public void ExitGame()
    {
        // Log a message to confirm the method is called
        Debug.Log("Exit button clicked!");

        // If running in the Unity editor, this will stop play mode
#if UNITY_EDITOR
        Debug.Log("Exiting Play Mode in Editor");
        UnityEditor.EditorApplication.isPlaying = false;
#else
        // If running in a build, this will close the application
        Debug.Log("Quitting Application");
        Application.Quit();
#endif
    }
}
