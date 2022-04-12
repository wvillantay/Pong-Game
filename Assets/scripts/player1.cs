using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class player1 : MonoBehaviour
{
    public float RacketSpeed;
    public Rigidbody2D rb;
    Vector2 RacketDirection;
    public string P1input = "vertical2";
    public string P2input = "vertical1";
    public bool player1ornot;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
       
    }

    // Update is called once per frame
    void Update()
    {
        if (player1ornot) //allows the poles/stick to move in a vertical movement
        {
        
        
            float DirectionY = Input.GetAxisRaw("vertical2"); //movmemnt of the right side.
            RacketDirection = new Vector2(0, DirectionY).normalized;
        }
        else //movement from the left side 
        {
            float DirectionY = Input.GetAxisRaw("vertical1");
            RacketDirection = new Vector2(0, DirectionY).normalized;
        }
        
      
    }
    private void FixedUpdate()
    {
        rb.velocity = RacketDirection * RacketSpeed;
    }
}
