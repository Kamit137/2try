using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Camera : MonoBehaviour
{
    float xRot;
    float yRot;
    public Camera player;
    public float sensivity =5f;
    public GameObject player_game;
    public float vertical_clamp;
    public MenuPaused menu;
    public bool MouseDis = true;

 void Update()
    {
        MouseMove();


    }
    void MouseMove()
    {
        xRot += Input.GetAxis("Mouse X") * sensivity ;
        yRot += Input.GetAxis("Mouse Y") * sensivity ;
        yRot = Mathf.Clamp(yRot, -vertical_clamp , vertical_clamp);

        player.transform.rotation = Quaternion.Euler(-yRot, xRot , 0f);
        player_game.transform.rotation = Quaternion.Euler(0f, xRot, 0f);
    }

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    
   
}
