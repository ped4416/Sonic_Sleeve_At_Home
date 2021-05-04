using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TwoMinTimer : MonoBehaviour
{
    public On50RepsListener fiftyRepsListener;
    public On2MinTimerEnd timerEnd;
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
        int i_restCountdown = 121 - timer;
        restCountdown.text = i_restCountdown.ToString();

        print("Time in seconds: " + timer);
        if (timer == 120)
        {
            timer = 0;
            End();
        }
        timer += 1;
    }

    public void End()
    {
        timerOn = false;
        StopCoroutine(TwoMinCoroutine());
        print("Check Start Position!");
        timerEnd.Raise();
    }
}
