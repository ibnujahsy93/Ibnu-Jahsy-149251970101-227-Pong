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
        
    }
    public void CreditScene()
    {
        Debug.Log("Credit Scene");
        SceneManager.LoadScene(2);

    }
    public void MainMenu()
    {
        Debug.Log("Main Menu");
        SceneManager.LoadScene(0);

    }

}
