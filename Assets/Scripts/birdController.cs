using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class birdController : MonoBehaviour
{
    GameObject obj;
    public float flyPower;
    void Start()
    {
    obj =gameObject;      
    flyPower =350;  
    }
   
     void endGame(){
            Debug.Log("end Game");
        }

    
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            obj.GetOrAddComponent<Rigidbody2D>().AddForce(new Vector2(0,flyPower));
        }

       
        // collision vs collision
        void collisionEnter2D(Collision2D other){
            endGame();
        }

        // void collisionStay2D(Collision2D other){

        // }

        // void collisionOut2D(Collision2D other){

        // }

        // //collision vs trigger
         void triggerEnter2D(){

        }

        // void triggerStay2D(){

        // }

        // void triggerOut2D(){
            
        // }
    }
}
