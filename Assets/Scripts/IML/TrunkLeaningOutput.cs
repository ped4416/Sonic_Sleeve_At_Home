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
    public OnErrorTimerStart errorTimerStart;
    public OnErrorTimerPause errorTimerPause;
    public OnErrorTimerStop errorTimerStop;
    public OnErrorTimerReset errorTimerReset;
    public ErrorTimerActive errorTimerCheck;
    public GameObject outputSlider;
    public GameObject threshSlider;

    private float f_prevVal;
    private float f_initialThresh;

    // Start is called before the first frame update
    void Start()
    {
        f_prevVal = 0.0f;

        f_initialThresh = PlayerPrefs.GetFloat("Trunk Leaning Threshold"); // value set from last runtime
        threshSlider.GetComponent<Slider>().value = f_initialThresh;

        errorTimerCheck.b_isActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        f_threshold = threshSlider.GetComponent<Slider>().value;

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

    public void StopResetError()
    {
        errorTimerStop.Raise();
        errorTimerReset.Raise();
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.SetFloat("Trunk Leaning Threshold", f_threshold);
    }
}
