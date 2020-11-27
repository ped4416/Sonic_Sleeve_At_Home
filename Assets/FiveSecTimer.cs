using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiveSecTimer : MonoBehaviour
{
    public OnFiveSecTimerEnd onFiveSecTimerEnd;

    private int timer;
    private bool timerOn;

    private void Start()
    {
        timer = 0;
        timerOn = false;
    }

    public void Begin()
    {
        print("5 second timer start!");
        timerOn = true;
        StartCoroutine(FiveSecCoroutine());

    }

    IEnumerator FiveSecCoroutine()
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
        if (timer == 5)
        {
            timer = 0;
            End();
        }
    }

    public void End()
    {
        timerOn = false;
        StopCoroutine(FiveSecCoroutine());
        onFiveSecTimerEnd.Raise();
    }
}
