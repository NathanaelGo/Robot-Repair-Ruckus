﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotControls : MonoBehaviour
{
    public string[] controls = new string[5];           //Controls used for player  |  Asigned in the Unity Editor
    public Rigidbody2D botRB;                           //Rigidbody for position movement 
    
    public float maxSpeed = 2.0f;                       //Speed of the player




    // Start is called before the first frame update
    void Start()
    {
        //Controls set in the Unity editor
        //Setting intial controls
        /*
        controls[0] = "w";
        controls[1] = "a";
        controls[2] = "d";
        controls[3] = "s";
        controls[4] = "f";
        */


    }

    // Update is called once per frame
    void Update()
    {
        
        //Movement Code

        if (Input.GetKey(controls[0]))
        {
            botRB.position += new Vector2 (0.0f, maxSpeed)*Time.deltaTime;
        }
        if (Input.GetKey(controls[1]))
        {
            botRB.position += new Vector2(-maxSpeed, 0.0f) * Time.deltaTime;
        }
        if (Input.GetKey(controls[2]))
        {
            botRB.position += new Vector2(maxSpeed, 0.0f) * Time.deltaTime;
        }
        if (Input.GetKey(controls[3]))
        {
            botRB.position += new Vector2(0.0f, -maxSpeed) * Time.deltaTime;
        }
        if (Input.GetKey(controls[4]))
        {
            interact();                                                                 
        }

    }



    public void interact()                                                              //Holder meathod for later use
    {
        Debug.Log("Interact Key Pressed");
    }


    public void updateControls(string[] newControls)                                    //Set controls
    {
        for(int i = 0; i < 5; i++)
        {
            controls[i] = newControls[i];
        }
    }
}