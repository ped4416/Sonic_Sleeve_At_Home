using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveShoulderThreshVal : MonoBehaviour
{
    public GameObject shoulderThreshSlider;
    public DataTracker dataTracker;

    public float f_shoulderVal;

    // Start is called before the first frame update
    void Awake()
    {
        shoulderThreshSlider.GetComponent<Slider>().value = PlayerPrefs.GetFloat("Shoulder Elevation Threshold");
    }

    void Update()
    {
        dataTracker.cal_shoulder = shoulderThreshSlider.GetComponent<Slider>().value;
    }

    public void SaveThreshVal()
    {
        f_shoulderVal = shoulderThreshSlider.GetComponent<Slider>().value;
        PlayerPrefs.SetFloat("Shoulder Elevation Threshold", f_shoulderVal);
    }
}
