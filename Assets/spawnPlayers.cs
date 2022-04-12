using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class spawnPlayers : MonoBehaviour
{
    public GameObject Player1;
    public GameObject Ball;
   
    public Transform Player1transform;
    public Transform Player2transform;
   
 
    // Start is called before the first frame update
    void Start()
    {
        if(PhotonNetwork.IsConnected)
        {
            SpawnPlayers();
        }
        
      
       
    }




    public void SpawnPlayers()
    {


        if (!PhotonNetwork.IsMasterClient)
        {


            PhotonNetwork.Instantiate(Ball.name, transform.position, Quaternion.identity);

            GameObject P1 = PhotonNetwork.Instantiate(Player1.name, Player1transform.position, Quaternion.identity);
            Debug.Log("player one is on pos" + P1.transform.position.x);

        }
        else
        {
            GameObject P2 = PhotonNetwork.Instantiate(Player1.name, Player2transform.position, Quaternion.identity);
            Debug.Log("player two is on pos" + P2.transform.position.x);

        }




    }



}
