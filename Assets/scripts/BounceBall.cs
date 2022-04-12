using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class BounceBall : MonoBehaviour
{
    public BallMovement ballmovement;
    
    public AudioSource As;
    
    public void bounce(Collision2D col)
    {
        Vector3 ballpos = transform.position;
        Vector3 playerpos = col.transform.position;
        float RacketHight = col.collider.bounds.size.y;
        float PosX;
        if (col.gameObject.CompareTag("Player1"))
        {
            PosX = 1;
            As.Play();
        }
        else
        {
            As.Play();
        
            PosX = -1;
        }
        float PosY = (ballpos.y - playerpos.y) / RacketHight;
        ballmovement.increasehitcounter();
        ballmovement.MoveBall(new Vector2(PosX, PosY));
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player1") || collision.gameObject.CompareTag("Player2"))//touching end of the border
        {

            bounce(collision);
        }
        if(collision.gameObject.CompareTag("LeftBorder"))//scoring the left side
        {
           
           
            StartCoroutine(ShowGameOverMenu(1));
        
        }
        if (collision.gameObject.CompareTag("RightBorder")) //scoring towards the right side
        {
           
         
            StartCoroutine(ShowGameOverMenu(2));
        
        }

    }

    IEnumerator ShowGameOverMenu(int whichplayer)
    {
        CameraEffects.instance.Shake();  // camera shaking for EFFECT
        yield return null;
        if(whichplayer==1)
        {
            GameManager.Instance.score1++;
    
           GameManager.Instance.Score1.text = GameManager.Instance.score1.ToString();
            StartCoroutine(changecolor(GameManager.Instance.Score1));
        }
        else
        {
            GameManager.Instance.score2++;
            GameManager.Instance.Score2.text = GameManager.Instance.score2.ToString();
            StartCoroutine(changecolor(GameManager.Instance.Score2));
    
        }
        StartCoroutine(DestroyAndSpawn());
        
    
       
    }
    IEnumerator changecolor(TMP_Text Stext) //adds color to score board
    {
        yield return null;
        Stext.color = Color.red; //adding color to scoreboard after the score has been made
        yield return new WaitForSeconds(.2f);
        Stext.color = Color.white; //the start color when game starts until it gets scored^^^^
    }
    public IEnumerator DestroyAndSpawn() //SPAWN THE BALL
    {
        yield return null;
        GameManager.Instance.SpawnBall(); //spawn center
        this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
        this.gameObject.GetComponent<TrailRenderer>().enabled = false;
        Destroy(this.gameObject); //Must destroy the ball to spawn one ball at the time 

    }
  

}
