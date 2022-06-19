using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadLengthPowerController : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball;
    public GameObject rightPad;
    public GameObject leftPad;
    
    public BallController baller;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            if (baller.lasthitByBall == true)
            {
                rightPad.GetComponent<PaddleController>().DoubleScale();
                manager.RemovePowerUp(gameObject);
                
            }
            else if (baller.lasthitByBall == false)
            {
                leftPad.GetComponent<PaddleController>().DoubleScale();
                manager.RemovePowerUp(gameObject);
                
            }
            return;


        }

    }
   

}
