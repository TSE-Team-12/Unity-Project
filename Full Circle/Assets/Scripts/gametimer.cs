﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gametimer : MonoBehaviour
{
    public Text timerText;
    private float startTime;
    private bool finnished = false;
    public string finishedTime;
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()

    {
        if (finnished)
            return;

        float t = Time.time - startTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f1");
        NextLevel.FinishedTime = minutes + ":" + seconds;

        timerText.text = minutes + ":" + seconds;
    }
    void Finnish()
    {
        finnished = true;
        timerText.color = Color.yellow;
    }
}
