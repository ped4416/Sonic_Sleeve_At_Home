using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TenSecTimer : MonoBehaviour
{
    public OnTenRepsListener tenRepsListener;
    public On10SecTimerEnd timerEnd;
    public OnRestStart restStart;
    public TMP_Text restCountdown;

    private int timer;
    private bool timerOn;

    private void Start()
    {
        timer = 0;
        timerOn = false;
    }

    public void Begin()
    {
        print("10 second timer start!");
        restStart.Raise();
        timerOn = true;
        StartCoroutine(TenSecCoroutine());
        
    }

    IEnumerator TenSecCoroutine()
    {
        while(timerOn)
        {
            increaseTime();
            yield return new WaitForSeconds(1);
        }
    }

    private void increaseTime()
    {
        int i_restCountdown = 10 - timer;
        restCountdown.text = i_restCountdown.ToString();

        print("Time in seconds: " + timer);
        if (timer == 10)
        {
            timer = 0;
            End();
        }
        else
        {
            timer += 1;
        }
    }

    public void End()
    {
        timerOn = false;
        StopCoroutine(TenSecCoroutine());
        print("Check Start Position!");
        timerEnd.Raise();
    }
}
