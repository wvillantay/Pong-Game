using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BallMovement : MonoBehaviour
{
    public float StartSpeed, ExtraSpeed, MaxSpeed;
    int hitCounter=0;
    Rigidbody2D rb;
   
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(LaunchBall()); // launching the ball vvvvvvvvvv
    }

   

    public void MoveBall(Vector2 direction) //the velocity of the ball 
    {
        direction = direction.normalized;
        float ballspeed = StartSpeed + hitCounter * ExtraSpeed;
        rb.velocity = direction * ballspeed;
    }

    public IEnumerator LaunchBall()
    {
        hitCounter = 0;
        yield return new WaitForSeconds(1f);// after the score has occured, wait a second before throwing the ball again
        MoveBall(new Vector2(-1, 0));//the direciton where the ball will be going
    }

    public void increasehitcounter()//the speed of the ball wil be going faster as the ball keeps hiting
    {
        if(hitCounter*ExtraSpeed<MaxSpeed)
        {
            hitCounter++;
        }
    }

    
}
