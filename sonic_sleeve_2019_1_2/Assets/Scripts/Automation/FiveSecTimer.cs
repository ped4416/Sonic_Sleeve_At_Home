using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FiveSecTimer : MonoBehaviour
{
    public OnFiveSecTimerEnd onFiveSecTimerEnd;
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
        int i_restCountdown = 6 - timer;
        restCountdown.text = i_restCountdown.ToString();

        print("Time in seconds: " + timer);
        if (timer == 5)
        {
            timer = 0;
            End();
        }
        timer += 1;
    }

    public void End()
    {
        timerOn = false;
        StopCoroutine(FiveSecCoroutine());
        onFiveSecTimerEnd.Raise();
    }
}
