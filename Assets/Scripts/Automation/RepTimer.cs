using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepTimer : MonoBehaviour
{
    public StopwatchTimer repTimer;
    public OnStopwatchStartListener repTimerStart;
    public OnStopwatchStopListener repTimerStop;
    public RepMs repTime;

    private void Start()
    {
        repTime.rep_ms = 0.0f;
    }

    private void Update()
    {
        repTime.rep_ms = repTimer.time;
    }

    public void StartRepTimer()
    {
        //print("Rep timer start");
        repTimer.StartTimer();
    }

    public void StopRepTimer()
    {
        //print("Rep timer stop");
        repTimer.StopTimer();
    }
}
