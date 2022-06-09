using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text leftScore;
    public Text rightScore;

    public ScoreManager manager;


    private void Update()
    {
        leftScore.text = manager.leftPadScore.ToString();
        rightScore.text = manager.rightPadScore.ToString();
    }
}
