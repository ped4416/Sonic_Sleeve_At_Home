using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockTimer : MonoBehaviour
{
    public StopwatchTimer timer;
    public OnStopwatchStartListener blockTimerStart;
    public OnStopwatchStopListener blockTimerStop;

    public void StartBlockTimer()
    {
        print("Block time start");
        timer.StartTimer();
    }

    public void StopBlockTimer()
    {
        print("Block timer stop");
        timer.StopTimer();
    }
}
