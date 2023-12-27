using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SoundHandler : MonoBehaviour
{

    public AudioClip flyClip0;
    public AudioClip flyClip1;
    public AudioClip flyClip2;
    public AudioClip flyClip3;
    public AudioClip flyClip4;
    public AudioClip flyClip5;
    public AudioClip flyClip6;
    public AudioClip flyClip7;
    public AudioClip deathClip;
    public AudioClip startClip;
    public AudioSource audioSource;
    public List<AudioClip> flySound;
    public BirdHandler birdHandler;

    //
    //start
    //
    void Start()
    {
        //  birdHandler = GetComponent<BirdHandler>();
        audioSource = GetComponent<AudioSource>();
        flySound = new List<AudioClip>();
        flySound.Add(flyClip0);
        flySound.Add(flyClip1);
        flySound.Add(flyClip2);
        flySound.Add(flyClip3);
        flySound.Add(flyClip4);
        flySound.Add(flyClip5);
        flySound.Add(flyClip6);
        flySound.Add(flyClip7);


        birdHandler.FlySoundEvent += FlySound;
        birdHandler.StartSoundEvent += StartSound;
        birdHandler.DeathSoundEvent += DeathSound;

    }

    //
    //update
    //
    void Update()
    {


    }

    //
    //method
    //

    void FlySound(object sender, EventArgs e)
    {
        int flag = 0;
        int randomSound = UnityEngine.Random.Range(0, 7);
        foreach (AudioClip sound in flySound)
        {
            flag++;
            if (flag == randomSound)
            {

                audioSource.clip = sound;
                audioSource.Play();
            }

        }
    }


    void DeathSound(object sender, EventArgs e)
    {
        audioSource.clip = deathClip;
        audioSource.Play();

    }



    void StartSound(object sender, EventArgs e)
    {
        audioSource.clip = startClip;
        audioSource.Play();
    }




}
