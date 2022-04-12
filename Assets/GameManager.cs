using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject Ball;
    public GameObject Ballspawn;
   public int score1 = 0;
    public int score2 = 0;
    public TMP_Text Score1, Score2;

    // Start is called before the first frame update
    void Start() //starting game
    {
        Debug.Log("");
        if(Instance==null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    public void SpawnBall() // scoreboard
    {
       
        Instantiate(Ball, Ballspawn.transform.position, Quaternion.identity);
        Debug.Log("call this func");
        if(score1==10) // right player score 
        {
            Menumanager.Instnce.player1win.SetActive(true);
            Menumanager.Instnce.background.SetActive(true);
            Menumanager.Instnce.playerAgain.SetActive(true);
            Menumanager.Instnce.ObjectstoDisapear.SetActive(false);
        }
        if (score2==10)//left player score maximum
        {
            Menumanager.Instnce.player2win.SetActive(true);

            Menumanager.Instnce.background.SetActive(true);
            Menumanager.Instnce.playerAgain.SetActive(true);
            Menumanager.Instnce.ObjectstoDisapear.SetActive(false);
        }
    }
    
}
