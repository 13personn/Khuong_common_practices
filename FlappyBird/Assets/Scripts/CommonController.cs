using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class CommonController : MonoBehaviour
{
    public BirdHandler birdHandler;
    int gamePoint = 0;
    bool isEnd = false;
    public Text textPoint;
    //
    //start
    //

    void Start()
    {
        //  birdHandler = GetComponent<BirdHandler>();
        Time.timeScale = 0;
        if(birdHandler==null)
        {
            Debug.Log("birdhandler in commoncontrolelr = null");
        }
         birdHandler.EndGameEvent += EndGame;
        

    }

    //
    //update
    //   

    void Update()
    {

        GameStatusHandler(isEnd);
    }

    //
    //method
    //

    public void GameStatusHandler(bool isEnd)
    {

        if (Input.GetMouseButtonDown(0) && isEnd == false)
        {
            Time.timeScale = 1;

        }
        if (Input.GetMouseButtonDown(0) && isEnd == true)
        {
            SceneManager.LoadScene(0);
            isEnd = false;
        }
    }




    public void GetPoint()
    {
        gamePoint++;
        textPoint.text = "Point:" + gamePoint.ToString();

    }

    public void EndGame(object sender, EventArgs e)
    {
        Time.timeScale = 0;

        isEnd = true;
    }
   
}
