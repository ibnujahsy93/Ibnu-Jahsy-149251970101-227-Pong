using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector2 speed;

    private Rigidbody2D ballRb;

    

    // Start is called before the first frame update
    void Start()
    {
        ballRb = GetComponent<Rigidbody2D>();
        ballRb.velocity = speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
