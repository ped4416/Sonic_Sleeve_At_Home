using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepTimer : MonoBehaviour
{
    public StopwatchTimer timer;
    public OnStopwatchStartListener stopwatchStart;
    public OnStopwatchStopListener stopwatchStop;

    public void StartRepTimer()
    {
        timer.StartTimer();
    }

    public void StopRepTimer()
    {
        timer.StopTimer();
    }
}
