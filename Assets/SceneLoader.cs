using UnityEngine;
using UnityEngine.SceneManagement; // Required for SceneManager

public class SceneLoader : MonoBehaviour
{
    public void LoadGameScene()
    {
        // Load the scene by its name
        SceneManager.LoadScene("SampleScene");
    }
    public void LoadMenuScene()
    {
        SceneManager.LoadScene("Menu");
    }
}
