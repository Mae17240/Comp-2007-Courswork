using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
using UnityEngine.UI;

public class Timer_script : MonoBehaviour
{
    public float timeRemaining = 0;
    public bool timeRunning = true;
    public TMP_Text timeText;


    void Start ()
    {
        timeRunning = true;

    }
    
    void Update ()
    {
        if (timeRunning)
        {
            if(timeRemaining >=0 )
            {
                timeRemaining += Time.deltaTime;
                DisplayTime(timeRemaining);

            }
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
