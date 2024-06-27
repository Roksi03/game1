using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitGame : MonoBehaviour
{
    public void QuitGame()
    {
        Debug.Log("Quitting game..."); // Optional debug message
        Application.Quit(); // Quits the application
    }
}