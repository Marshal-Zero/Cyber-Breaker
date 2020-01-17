using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] Paddle paddle1;

    //speed
     public float ySpeed = 10f;    
     public float xSpeed = 2f;
    

    //state
    Vector2 paddleToBallVector;
    Boolean hasStarted = false;

    void Start()
    {
        //no need to specify which transform.position in first operand
        //because it belongs to this game object which is the ball
        paddleToBallVector = transform.position - paddle1.transform.position;
    }
  
    void Update()
    {
        if (hasStarted == false)
        {
            LockBallToPaddle();
            LaunchOnMouseClick();
        }
                                  
    }




    private void LaunchOnMouseClick()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            hasStarted = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(xSpeed, ySpeed);
        }
    }

    private void LockBallToPaddle()
    {
        Vector2 paddlePos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
        transform.position = paddleToBallVector + paddlePos;
    }
}
