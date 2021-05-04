using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WristToggleTracker : MonoBehaviour
{
    public TMP_Dropdown armDropdown;
    public WristDataTracker wristDataTracker;
    public Vec3LowPassFilter vec3LowPassFilter;
    public int thisArm; // 0 = right, 1 = left

    private int i_armValue;

    // Update is called once per frame
    void Update()
    {
        i_armValue = armDropdown.GetComponent<TMP_Dropdown>().value;
        if (thisArm == 1 && i_armValue == 0)
        {
            wristDataTracker.enabled = false;
            vec3LowPassFilter.enabled = false;
        }
        else if (thisArm == 0 && i_armValue == 1)
        {
            wristDataTracker.enabled = false;
            vec3LowPassFilter.enabled = false;
        }
        else if (thisArm == 0 && i_armValue == 0)
        {
            wristDataTracker.enabled = true;
            vec3LowPassFilter.enabled = true;
        }
        else if (thisArm == 1 && i_armValue == 1)
        {
            wristDataTracker.enabled = true;
            vec3LowPassFilter.enabled = true;
        }
    }
}
