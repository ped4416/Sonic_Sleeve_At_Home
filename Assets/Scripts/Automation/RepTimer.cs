using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepTimer : MonoBehaviour
{
    public StopwatchTimer stopwatchTimer;
    public RepMs repTime;

    private void Start()
    {
        repTime.rep_ms = 0.0f;
    }

    public void UpdateRepMs()
    {
        double timeVal = stopwatchTimer.GetTimeSeconds();
        repTime.rep_ms = timeVal;
    }
}
