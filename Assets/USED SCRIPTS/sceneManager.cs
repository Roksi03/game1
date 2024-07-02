using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    public Button yourButton;

    void Start()
    {
        if (yourButton != null)
        {
            yourButton.onClick.AddListener(LoadNextScene);
        }
    }

    public void LoadNextScene()
    {
        // Get the current active scene index
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        // Load the next scene in the build order
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}