using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ErrorTimer : MonoBehaviour
{
    public StopwatchTimer timer;
    public OnStopwatchStartListener errorTimerStart;
    public OnStopwatchPauseListener errorTimerPause;
    public OnStopwatchStopListener errorTimerStop;

    public void StartErrorTimer()
    {
        print("ERROR TIMER START");
        timer.StartTimer();
    }

    public void StopErrorTimer()
    {
        print("ERROR TIMER STOP");
        timer.StopTimer();
    }

    public void PauseErrorTimer()
    {
        print("ERROR TIMER PAUSE");
        timer.PauseTimer();
    }
}
