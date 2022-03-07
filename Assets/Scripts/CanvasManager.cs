using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{

    public Text WaveText;
    public Text PointsText;
    public Game CurGame;
    public NetworkManager nManager;
    int curWav = -1;

    // Start is called before the first frame update
    void Start()
    {
        WaveText.text = "Wave: " + nManager.WaveNum;
        PointsText.text = "Points: " + CurGame.playerScore;

    }

    // Update is called once per frame
    void Update()
    {
        PointsText.text = "Points: " + CurGame.playerScore;

        if (curWav != nManager.WaveNum)
        {
            WaveText.text = "Wave: " + nManager.WaveNum;
            curWav += 1;
        }


    }





}
