using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockTimer : MonoBehaviour
{
    public StopwatchTimer blockTimer;
    public OnStopwatchStartListener blockTimerStart;
    public OnStopwatchStopListener blockTimerStop;

    public void StartBlockTimer()
    {
        //print("Block time start");
        blockTimer.StartTimer();
    }

    public void StopBlockTimer()
    {
        //print("Block timer stop");
        blockTimer.StopTimer();
    }
}
