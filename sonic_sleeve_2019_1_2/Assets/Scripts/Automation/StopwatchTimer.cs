using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using System;

public class StopwatchTimer : MonoBehaviour
{
    public OnBang bang;

    private Stopwatch stopwatch = new Stopwatch();

    public void StartTimer()
    {
        stopwatch.Start();
        InvokeRepeating("RaiseBang", 0.0f, 0.02f);
        print("Timer Start********************************");
    }

    public void StopTimer()
    {
        stopwatch.Stop();
        CancelInvoke();
    }

    public void ResetTimer()
    {
        stopwatch.Reset();
    }

    public double GetTimeSeconds()
    {
        TimeSpan time = stopwatch.Elapsed;
        double timeVal = time.TotalSeconds;

        return timeVal;
    }

    private void RaiseBang()
    {
        bang.Raise();
    }
}
