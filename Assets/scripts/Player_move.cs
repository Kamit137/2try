using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_move : MonoBehaviour
{
    public float gr;
    public float speed_Move =9f;
    public float speed_run = 13f;
    public float speed_current;
    public float speed_low = 4.5f;
    float xMove;
    float zMove;
    float jumpMove;
    Vector3 Jumpheightv;
    CharacterController Player;
    Vector3 Move_D;
    public float Jumpheight = 1.5f;
  
   

    // Start is called before the first frame update
    void Start()
    {
        Player = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        zMove = Input.GetAxis("Vertical");
        xMove = Input.GetAxis("Horizontal");
        Jumpheightv = new Vector3(0f, Jumpheight, 0f);

        if (Player.isGrounded)
        {
            Move_D = new Vector3(xMove, 0f, zMove);
            Move_D = transform.TransformDirection(Move_D);
            if (Input.GetKey(KeyCode.Space))
            {
                Move_D = Move_D + Jumpheightv;
            }
            if (Input.GetKey(KeyCode.LeftControl))//-------------------------
            {
                Player.height = 2.3f;
                speed_current = speed_low;
            }
            else
            {
                Player.height = 4;
                speed_current = speed_Move;
            }
        }
        Move_D.y -= gr;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed_current = speed_run;
        }
        else
        {
            speed_current = speed_Move;
        }
        
        Player.Move(Move_D * speed_current * Time.deltaTime);
        
    
    }
}
