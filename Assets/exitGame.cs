using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exitGame : MonoBehaviour
{
    public void QuitGame()
    {
        Debug.Log("Quitting game..."); // Optional debug message
        Application.Quit(); // Quits the application
    }

    public void LoadMenu()
    {
        Debug.Log("Loading Menu...");
        SceneManager.LoadScene("menu");
    }
}