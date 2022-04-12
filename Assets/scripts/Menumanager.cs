using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menumanager : MonoBehaviour
{
    public GameObject background;
    public GameObject changecolor;
    public GameObject playbuttton;
    public GameObject[] ObjectstoApear;
    public static Menumanager Instnce;
    public GameObject ObjectstoDisapear;
    public GameObject player1win;
    public GameObject player2win;
    //public GameObject player1lost;
    //public GameObject player2lost;
    public GameObject PongGlow;
    public GameObject playerAgain;
    private void Awake()
    {
        if(Instnce==null)
        {
            Instnce = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayGame()
    {
       
        playbuttton.SetActive(false);
        changecolor
            .SetActive(false);
    
        for(int i=0;i<ObjectstoApear.Length;i++)
        {
            ObjectstoApear[i].SetActive(true);
        }
    
    
    }


    public void PlayAgain()
    {


        SceneManager.LoadScene(0);


    }

    
}
