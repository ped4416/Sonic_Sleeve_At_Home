using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InteractML;
using UnityEngine.UI;

public class ShoulderAbductionOutput : MonoBehaviour
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
    public GameObject audioSource;
    public DataTracker dataTracker;
    public RepTimerActive repTimerActive;

    private float f_prevVal;
    private float f_initialThresh;

    // Start is called before the first frame update
    void Start()
    {
        f_prevVal = 0.0f;

        //f_initialThresh = PlayerPrefs.GetFloat("Shoulder Abduction Threshold"); // default value
        //threshSlider.GetComponent<Slider>().value = f_initialThresh;

        errorTimerCheck.b_isActive = false;
        dataTracker.is_in_error = false;
    }

    // Update is called once per frame
    void Update()
    {
        f_threshold = threshSlider.GetComponent<Slider>().value;
      
        float f_currentVal;
        f_currentVal = f_MLPOutputValue;

        if(GUItoIML.b_runModel)
        {
            outputSlider.GetComponent<Slider>().value = f_currentVal;
        }
        
       // if (f_currentVal != f_prevVal) print("Shoulder Abduction Output = " + f_currentVal);

        if (f_currentVal >= f_threshold && f_prevVal < f_threshold)
        {
            if(!errorTimerCheck.b_isActive)
            {
                print("Shoulder abduction adjustment needed");

                if(dataTracker.e_condition == DataTracker.Condition.Experimental || dataTracker.e_condition == DataTracker.Condition.Practice)
                {
                    audioSource.GetComponent<AudioSource>().volume = 0.0f;
                }
                
                if(repTimerActive.b_isActive)
                {
                    errorTimerStart.Raise();
                    dataTracker.is_in_error = true;
                    errorTimerCheck.b_isActive = true;
                }                
            }
            
        }
        else if (f_currentVal < f_threshold && f_prevVal >= f_threshold)
        {
            if(errorTimerCheck.b_isActive)
            {
                audioSource.GetComponent<AudioSource>().volume = 1.0f;
                errorTimerPause.Raise();
                dataTracker.is_in_error = false;
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

    /*private void OnApplicationQuit()
    {
        PlayerPrefs.SetFloat("Shoulder Abduction Threshold", f_threshold);
    }*/
}
