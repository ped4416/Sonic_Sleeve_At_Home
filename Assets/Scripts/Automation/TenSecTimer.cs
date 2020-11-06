using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TenSecTimer : MonoBehaviour
{
    public OnTenRepsListener tenRepsListener;
    public OnTimerEnd timerEnd;
    public OnRestStart restStart;

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
        timer += 1;
        print("Time in seconds: " + timer);
        if (timer == 10)
        {
            timer = 0;
            End();
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
