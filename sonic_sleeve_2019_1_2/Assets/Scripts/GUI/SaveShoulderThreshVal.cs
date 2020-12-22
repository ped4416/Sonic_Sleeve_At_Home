using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveShoulderThreshVal : MonoBehaviour
{
    public GameObject shouderThreshSlider;

    public float f_shoulderVal;

    // Start is called before the first frame update
    void Awake()
    {
        shouderThreshSlider.GetComponent<Slider>().value = PlayerPrefs.GetFloat("Shoulder Elevation Threshold");
    }

    public void SaveThreshVal()
    {
        f_shoulderVal = shouderThreshSlider.GetComponent<Slider>().value;
        PlayerPrefs.SetFloat("Shoulder Elevation Threshold", f_shoulderVal);
    }
}
