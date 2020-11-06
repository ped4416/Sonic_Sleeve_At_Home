using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoMinTimer : MonoBehaviour
{
    public On50RepsListener fiftyRepsListener;
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
        print("2 minute timer start!");
        restStart.Raise();
        timerOn = true;
        StartCoroutine(TwoMinCoroutine());

    }

    IEnumerator TwoMinCoroutine()
    {
        while (timerOn)
        {
            increaseTime();
            yield return new WaitForSeconds(1);
        }
    }

    private void increaseTime()
    {
        timer += 1;
        print("Time in seconds: " + timer);
        if (timer == 120)
        {
            timer = 0;
            End();
        }
    }

    public void End()
    {
        timerOn = false;
        StopCoroutine(TwoMinCoroutine());
        print("Check Start Position!");
        timerEnd.Raise();
    }
}
