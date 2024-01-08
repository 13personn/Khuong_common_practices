using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{

    public CommonController commonController;
    public BirdHandler birdHandler;
    public GameObject pnlEnd;
    public Button btnPlay;
    public Text totalPoint;
    public Text textPoint;
    void Start()
    {

        pnlEnd.SetActive(false);
        birdHandler.PanelEvent += ShowPnlEndGame;

    }




    public void ShowPnlEndGame(object sender, EventArgs e)
    {
        pnlEnd.SetActive(true);
        totalPoint.text = textPoint.text.Length > 6 ? "Total " + textPoint.text : "Total Point: 0";

    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);

    }
}
