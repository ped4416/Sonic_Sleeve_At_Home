using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InteractML;
using System.ComponentModel;

public class ShoulderElevationOutput : MonoBehaviour
{
    [PullFromIMLController]
    public float f_MLPOutputValue;
    public float f_threshold;
    //public OnAboveThresh aboveThresh_shoulderElev;
    //public OnBelowThresh belowThresh_shoulderElev;
    public OnStopwatchStart errorTimerStart;
    public OnStopwatchPause errorTimerPause;

    private float f_prevVal;
    // Start is called before the first frame update
    void Start()
    {
        f_prevVal = 0.0f;
        f_threshold = 0.2f; // default value
    }

    // Update is called once per frame
    void Update()
    {
        float f_currentVal;
        f_currentVal = f_MLPOutputValue;

        //if (f_currentVal != f_prevVal) print("Shoulder Elevation Output = " + f_currentVal);

        if(f_currentVal >= f_threshold && f_prevVal < f_threshold)
        {
            // raise event above threshold
            // call start error timer
            // pause music
            //aboveThresh_shoulderElev.Raise();
            errorTimerStart.Raise();
        }
        else if(f_currentVal < f_threshold && f_prevVal >= f_threshold)
        {
            // raise event below threshold
            // call pause error timer
            // play music
            //belowThresh_shoulderElev.Raise();
            errorTimerPause.Raise();
        }

        f_prevVal = f_currentVal;
    }
}
