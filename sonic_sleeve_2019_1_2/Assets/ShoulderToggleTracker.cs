using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShoulderToggleTracker : MonoBehaviour
{
    public TMP_Dropdown armDropdown;
    public ShoulderDataTracker shoulderDataTracker;
    public Vec3LowPassFilter vec3LowPassFilter;
    public int thisArm; // 0 = right, 1 = left

    private int i_armValue;

    // Update is called once per frame
    void Update()
    {
        i_armValue = armDropdown.GetComponent<TMP_Dropdown>().value;
        if(thisArm == 1 && i_armValue == 0)
        {
            shoulderDataTracker.enabled = false;
            vec3LowPassFilter.enabled = false;
        } 
        else if(thisArm == 0 && i_armValue ==1)
        {
            shoulderDataTracker.enabled = false;
            vec3LowPassFilter.enabled = false;
        }
        else if(thisArm == 0 && i_armValue == 0)
        {
            shoulderDataTracker.enabled = true;
            vec3LowPassFilter.enabled = true;
        }
        else if(thisArm == 1 && i_armValue == 1)
        {
            shoulderDataTracker.enabled = true;
            vec3LowPassFilter.enabled = true;
        }
    }
}
