using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ErrorTimer : MonoBehaviour
{
    public StopwatchTimer errorTimer;
    public OnStopwatchStartListener errorTimerStart;
    public OnStopwatchPauseListener errorTimerPause;
    public OnStopwatchStopListener errorTimerStop;
    public RepError repError;

    private void Start()
    {
        repError.rep_error_ms = 0.0f;
    }

    /*private void Update()
    {
        repError.rep_error_ms = errorTimer.time;
    }*/

    public void StartErrorTimer()
    {
        //print("ERROR TIMER START");
        errorTimer.StartTimer();
    }

    public void StopErrorTimer()
    {
        //print("ERROR TIMER STOP");
        errorTimer.StopTimer();
    }

    /*public void PauseErrorTimer()
    {
        //print("ERROR TIMER PAUSE");
        errorTimer.PauseTimer();
    }*/
}
