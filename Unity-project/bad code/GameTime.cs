using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.UI;

public class GameTime : MonoBehaviour
{
    public float timeStart = 0;
    public float second1;
    public float second2;
    public float secondF;
    public float minute;
    public Text timerText;
    public float timeFinish;
    public float timeStop;
    public bool done;
    public Text SecondTimer;
    public SpawnManager SM;

    void Start()
    {
        timerText.text = timeStart.ToString();
        
    }

    void Update()
    {
        //if (Time.deltaTime != null)
        //{
        //    timeStart -= Time.deltaTime;
        //    timeFinish = timeStart + timeStop;
        //    second1 = timeFinish * 100;
        //    second2 = Mathf.Round(second1);
        //    secondF = second2 / 100;
        //    timerText.text = secondF.ToString();
        //}
        if (timeStart <= 0)
        {
            SM.TimerDone = true;
            timerText.text = "0:00";
            SecondTimer.text = "0:00";
        }
        else
        {
            timeStart -= Time.deltaTime;

            minute = Mathf.FloorToInt(timeStart / 60F);
            second1 = Mathf.FloorToInt(timeStart - minute * 60);
            timerText.text = string.Format("{0:0}:{1:00}", minute, second1);
            SecondTimer.text = string.Format("{0:0}:{1:00}", minute, second1);
        }
        
        

        //GUI.Label(new Rect(10, 10, 250, 100), niceTime);

    }
}