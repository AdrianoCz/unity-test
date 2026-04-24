using UnityEngine;
using UnityEngine.SceneManagement; // Required for SceneManager

public class SceneLoader : MonoBehaviour
{
    public void LoadGameScene(string x)
    {
        // Load the scene by its name
        SceneManager.LoadScene(x);
    }
}
