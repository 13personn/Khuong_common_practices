using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class BirdHandler : MonoBehaviour
{

    public event EventHandler EndGameEvent;
    public  event EventHandler FlySoundEvent;
    public  event EventHandler StartSoundEvent;
    public event EventHandler DeathSoundEvent;
    public float flyPower;
    // public GameObject obj;
//     public CommonController commonController;
//    public SoundHandler soundHandler;

    //
    ///start
    //
    void Start()
    {
       flyPower =350;
        StartSoundEvent?.Invoke(this,EventArgs.Empty);

        
        // audioSource = gameControllers.GetOrAddComponent<AudioSource>();  
    }

    //
    //update
    //

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            BirdMove();
        }


    }

    //
    //update
    //
    void BirdMove()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(5,flyPower));

            FlySoundEvent?.Invoke(this,EventArgs.Empty);

    }

    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.tag == "Finish")
        {

                EndGameEvent?.Invoke(this,EventArgs.Empty);
                DeathSoundEvent?.Invoke(this,EventArgs.Empty);

        }
    }




    // void OnTriggerEnter2D(Collider2D col)
    // {
    //     Debug.Log("0");
    //     if (col.gameObject.tag == "PointTrigger")
    //     {
    //         Debug.Log("1");

    //     }
    // }



}

