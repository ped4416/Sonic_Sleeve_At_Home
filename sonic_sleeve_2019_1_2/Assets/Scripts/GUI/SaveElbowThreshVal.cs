using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveElbowThreshVal : MonoBehaviour
{
    public GameObject slider;

    public float f_val;

    // Start is called before the first frame update
    void Awake()
    {
        slider.GetComponent<Slider>().value = PlayerPrefs.GetFloat("Shoulder Abduction Threshold");
    }

    public void SaveThreshVal()
    {
        f_val = slider.GetComponent<Slider>().value;
        PlayerPrefs.SetFloat("Shoulder Abduction Threshold", f_val);
    }
}
