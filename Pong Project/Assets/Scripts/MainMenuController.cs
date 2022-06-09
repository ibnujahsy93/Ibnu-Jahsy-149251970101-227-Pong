using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{

    public void PlayGame()
    {
        Debug.Log("Created by [Ibnu Jahsy] - [149251970101-227]");
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        Debug.Log("Exit");
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }

}
