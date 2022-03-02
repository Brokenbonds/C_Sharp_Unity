using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Timer : MonoBehaviour
{

    public int startMinutes;
    public Text currentTimeText;
    public bool timerActive = false;

    private float currentTime;
    

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startMinutes * 60;
        StartTimer();
    }

    // Update is called once per frame
    void Update()
    {
        TimeRuner();
        
    }

    public void StartTimer()
    {
        timerActive = true;
    }

    public void StopTimer()
    {
        timerActive = false;
    }

    void TimeRuner()
    {
        if (timerActive)
        {
            currentTime = currentTime + Time.deltaTime;
        }
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        if (time.Seconds <= 9 && time.Minutes <= 9)
        {
            currentTimeText.text = "0" + time.Minutes.ToString() + ":0" + time.Seconds.ToString();
        }

        else if (time.Seconds > 9 && time.Minutes <= 9)
        {
            currentTimeText.text = "0" + time.Minutes.ToString() + ":" + time.Seconds.ToString();
        }

        else
        {
            currentTimeText.text = time.Minutes.ToString() + ":" + time.Seconds.ToString();
        }
    }
}
