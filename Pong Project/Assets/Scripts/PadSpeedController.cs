using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadSpeedController : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball;
    public Collider2D rightPad;
    public Collider2D leftPad;
    public BallController baller;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            if (baller.lasthitByBall == true)
            {
                rightPad.GetComponent<PaddleController>().ActivateSpeedPower();
                manager.RemovePowerUp(gameObject);
                
            }
            else if (baller.lasthitByBall == false)
            {
                leftPad.GetComponent<PaddleController>().ActivateSpeedPower();
                manager.RemovePowerUp(gameObject);
                
            }
            return;
            
        }

    }


   

}
