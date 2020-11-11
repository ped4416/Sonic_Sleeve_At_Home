using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopwatchTimer : MonoBehaviour
{
    private float time;
    private bool startTimer;

    private void Start()
    {
        time = 0.0f;
    }

    private void Update()
    {
        if(startTimer)
        {
            time += Time.deltaTime;
            print(time.ToString("F2"));
        }
    }
    public void StartTimer()
    {
        startTimer = true;
    }

    public void StopTimer()
    {
        startTimer = false;
        time = 0.0f;
    }

    public void PauseTimer()
    {
        startTimer = false;
    }
}
