using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class BirdHandler : MonoBehaviour
{

    Boolean isEnd = false;
    public event EventHandler EndGameEvent;
    public event EventHandler FlySoundEvent;
    public event EventHandler StartSoundEvent;
    public event EventHandler DeathSoundEvent;
    public event EventHandler PointEvent;
    public event EventHandler PanelEvent;
    public float flyPower;
    // public GameObject obj;
    //     public CommonController commonController;
    //    public SoundHandler soundHandler;

    //
    ///start
    //
    void Start()
    {
        flyPower = 350;
        StartSoundEvent?.Invoke(this, EventArgs.Empty);


        // audioSource = gameControllers.GetOrAddComponent<AudioSource>();  
    }

    //
    //update
    //

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && isEnd == false)
        {
            BirdMove();
        }


    }

    //
    //update
    //
    void BirdMove()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0, flyPower));

        FlySoundEvent?.Invoke(this, EventArgs.Empty);

    }

    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.tag == "Finish")
        {

            EndGameEvent?.Invoke(this, EventArgs.Empty);
            DeathSoundEvent?.Invoke(this, EventArgs.Empty);
            PanelEvent?.Invoke(this, EventArgs.Empty);
            isEnd = true;

        }
    }




    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("0");
        if (col.tag.Equals("PointTrigger"))
        {
            PointEvent?.Invoke(this, EventArgs.Empty);

        }
    }





}

