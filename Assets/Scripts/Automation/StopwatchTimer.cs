using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using System;

public class StopwatchTimer : MonoBehaviour
{
    public OnBang bang;

    private Stopwatch stopwatch = new Stopwatch();
    private bool b_isRunning;

    private void Start()
    {
        b_isRunning = false;
    }

    private void Update()
    {
        if(b_isRunning)
        { 
            long milliTime = stopwatch.ElapsedMilliseconds;
            if (milliTime >= 20)
            {
                print("BANG");
                bang.Raise();
            }
        }
    }
    public void StartTimer()
    {
        b_isRunning = true;
        stopwatch.Start();
    }

    public void StopTimer()
    {
        b_isRunning = false;
        stopwatch.Stop();
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

    /*public void Bang()
    {
        while(b_isRunning)
        {
            print("BANG");
            long milliTime = stopwatch.ElapsedMilliseconds;
            if (milliTime >= 20) bang.Raise();
        }
    }*/
}
