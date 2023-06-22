using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timerRemaining = 0;
    public bool timeIsRunning = true;
    public Text timeText;

    public int timeLength = 180;

    void Update()
    {
        if (timeIsRunning)
        {
            timerRemaining += Time.deltaTime;
            DisplayTime(timerRemaining);
        }

        if(timerRemaining > timeLength - 1)
        {
            timeIsRunning = false;
        }
    }

    void DisplayTime (float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
}
