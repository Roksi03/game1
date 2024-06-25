using UnityEngine;
using UnityEngine.SceneManagement;

public class EscapeSceneLoader : MonoBehaviour
{
    // Name or index of the scene to load when Escape is pressed
    public string sceneToLoad = "YourSceneName"; // You can use the scene name or the scene index

    void Update()
    {
        // Check if the Escape key is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Load the specified scene
            SceneManager.LoadScene("tutorialWin");
        }
    }
}