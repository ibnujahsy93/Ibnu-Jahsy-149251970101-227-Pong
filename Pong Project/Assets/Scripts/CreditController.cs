using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditController : MonoBehaviour
{
    // Start is called before the first frame update
    public void MainMenu()
    {
        Debug.Log("Main Menu");
        SceneManager.LoadScene(0);

    }
}
