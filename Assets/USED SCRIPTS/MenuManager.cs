using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // Import this if you need to interact with UI elements

public class MenuManager : MonoBehaviour
{
    // This function will be called when the button is clicked
    public void LoadScene(string menu)
    {
        SceneManager.LoadScene(menu);
    }
}