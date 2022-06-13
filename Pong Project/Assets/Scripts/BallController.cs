using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    
    public Vector2 resetPosition;
    
    private Rigidbody2D ballRb;

    

    // Start is called before the first frame update
    void Start()
    {
        ballRb = GetComponent<Rigidbody2D>();
        ballRb.velocity = RandomSpeedBall();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetBall()
    {
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 2);
        ballRb.velocity = RandomSpeedBall();
    }

    private Vector2 RandomSpeedBall()
    {

        float vectorValueX = 0;
        float vectorValueY = 0;

        float valueX = Random.Range(-9f, 9f);
        if(valueX >= 0)
        {
            vectorValueX = Random.Range(5f, 9f);
        }
        else
        {
            vectorValueX = Random.Range(-3f, -5f);
        }
        float valueY = Random.Range(-9f, 9f);
        if (valueY >= 0)
        {
            vectorValueY = Random.Range(5f, 9f);
        }
        else
        {
            vectorValueY = Random.Range(-3f, -5f);
        }


        Vector2 randomVector = new Vector2(vectorValueX, vectorValueY);
        return randomVector;
    }

    public void ActivateSpeedPower(float magnitude)
    {
        ballRb.velocity *= magnitude;
    }
}
