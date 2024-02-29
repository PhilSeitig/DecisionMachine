using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenenLoader : MonoBehaviour
{
    // Script to load scene
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    // Script to quit the game, with debug funktion to test in Unity
    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}