using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed = 5;
    
    public KeyCode upkey;
    public KeyCode downkey;
    public Collider2D ball;

    private GameObject paddle;
    public Vector2 resetScale;

    public bool hasPowerUp = false;
    private Rigidbody2D paddleRb;
    private float timer;
    private float timer2;

    // Start is called before the first frame update
    void Start()
    {
        paddleRb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        MoveObject(GetInput());
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            NormalSpeed();
            timer = 0;

        }

        if (timer2 > 0)
        {
            timer2 -= Time.deltaTime;
        }
        else
        {
            NormalScale();
            timer2 = 0;

        }
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
        
        return Vector2.zero;
    }
    private void MoveObject(Vector2 movement)
    {
        
        paddleRb.velocity = movement;
    }


    public void ActivateSpeedPower()
    {
        speed *= 2;
        timer = 5;

    }
    public void NormalSpeed()
    {
        speed = 5;
    }

    public void DoubleScaleR()
    {
        transform.localScale = new Vector2(transform.localScale.x, transform.localScale.y*2);
        timer2 = 5;
    }
    public void DoubleScaleL()
    {
        transform.localScale = new Vector2(transform.localScale.x, transform.localScale.y * 2);
        timer2 = 5;
    }
    public void NormalScale()
    {
        transform.localScale = new Vector2(0.4675952f, 1.2f);
    }
   


}
