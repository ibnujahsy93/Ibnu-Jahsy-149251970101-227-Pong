using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int leftPadScore;
    public int rightPadScore;

    public int maxScore;

    public BallController ball;

    public void AddLeftScore(int increment)
    {
        leftPadScore += increment;
        ball.ResetBall();
        if (leftPadScore >= maxScore)
        {
            GameOver();
        }
    }

    public void AddRightScore(int increment)
    {
        rightPadScore += increment;
        ball.ResetBall();
        if (rightPadScore >= maxScore)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene(0);
    }

}
