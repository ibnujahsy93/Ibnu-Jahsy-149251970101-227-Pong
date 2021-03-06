using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerController : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball;
    public float magnitude;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            ball.GetComponent<BallController>().ActivateSpeedPower(magnitude);
            manager.RemovePowerUp(gameObject);
        }
        
    }

}
