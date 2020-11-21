using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InteractML;
using UnityEngine.UI;

public class TrunkLeaningOutput : MonoBehaviour
{
    [PullFromIMLController]
    public float f_MLPOutputValue;
    public float f_threshold;
    public OnStopwatchStart errorTimerStart;
    public OnStopwatchPause errorTimerPause;
    public ErrorTimerActive errorTimerCheck;
    public GameObject outputSlider; 

    private float f_prevVal;
    // Start is called before the first frame update
    void Start()
    {
        f_prevVal = 0.0f;
        f_threshold = 0.2f; // default value
        errorTimerCheck.b_isActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        float f_currentVal;
        f_currentVal = f_MLPOutputValue;
        if (GUItoIML.b_runModel)
        {
            outputSlider.GetComponent<Slider>().value = f_currentVal;
        }

        //if (f_currentVal != f_prevVal) print("Trunk Leaning Output = " + f_currentVal);

        if (f_currentVal >= f_threshold && f_prevVal < f_threshold)
        {
            if(!errorTimerCheck.b_isActive)
            {
                print("Trunk adjustment needed");
                errorTimerStart.Raise();
                errorTimerCheck.b_isActive = true;
            }
            
        }
        else if (f_currentVal < f_threshold && f_prevVal >= f_threshold)
        {
            if(errorTimerCheck.b_isActive)
            {
                errorTimerPause.Raise();
                errorTimerCheck.b_isActive = false;
            }
            
        }

        f_prevVal = f_currentVal;
    }
}
