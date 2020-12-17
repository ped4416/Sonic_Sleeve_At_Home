using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ErrorTimer : MonoBehaviour
{
    public StopwatchTimer stopwatchTimer;
    public DataTracker dataTracker;

    private void Start()
    {
        dataTracker.rep_error_ms = 0.0f;
    }

    public void UpdateErrorMs()
    {
        double timeVal = stopwatchTimer.GetTimeSeconds();
        dataTracker.rep_error_ms = timeVal;
    }
}
