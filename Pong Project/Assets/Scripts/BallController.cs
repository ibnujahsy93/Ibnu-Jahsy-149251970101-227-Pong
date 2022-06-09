using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector2 speed;
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
        float minValueX = Random.Range(-5f, -9f);
        float maxValueX = Random.Range(5f, 9f);
        float minValueY = Random.Range(-1f, -5f);
        float maxValueY = Random.Range(1f, 5f);

        Vector2 randomVector = new Vector2(Random.Range(minValueX, maxValueX), Random.Range(minValueY, maxValueY));
        return randomVector;
    }
}
