using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepTimer : MonoBehaviour
{
    public StopwatchTimer stopwatchTimer;
    public DataTracker dataTracker;

    private void Start()
    {
        dataTracker.rep_ms = 0.0f;
    }

    public void UpdateRepMs()
    {
        double timeVal = stopwatchTimer.GetTimeSeconds();
        dataTracker.rep_ms = timeVal;
    }
}
