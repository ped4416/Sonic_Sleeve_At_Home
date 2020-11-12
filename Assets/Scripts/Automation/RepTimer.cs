using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepTimer : MonoBehaviour
{
    public StopwatchTimer timer;
    public OnStopwatchStartListener repTimerStart;
    public OnStopwatchStopListener repTimerStop;
    public RepMs repTime;

    public void StartRepTimer()
    {
        print("Rep timer start");
        timer.StartTimer();
    }

    public void StopRepTimer()
    {
        repTime.rep_ms = timer.GetCurrentTime();
        print("Rep timer stop");
        timer.StopTimer();
    }
}
