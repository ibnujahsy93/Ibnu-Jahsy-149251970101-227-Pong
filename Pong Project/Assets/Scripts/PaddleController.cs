using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed = 5;
    public KeyCode upkey;
    public KeyCode downkey;

    private Rigidbody2D paddleRb;

    // Start is called before the first frame update
    void Start()
    {
        paddleRb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
       
        MoveObject(GetInput());

    }

    private Vector2 GetInput()
    {
        if (Input.GetKey(upkey))
        {
            return Vector2.up * speed;
            
        }
        else if (Input.GetKey(downkey))
        {
            return Vector2.down * speed;
            
        }
        Debug.Log("Movement Paddle = " + speed);
        return Vector2.zero;
    }
    private void MoveObject(Vector2 movement)
    {
        Debug.Log("Movement Paddle = "+movement);
        paddleRb.velocity = movement;
    }
}
