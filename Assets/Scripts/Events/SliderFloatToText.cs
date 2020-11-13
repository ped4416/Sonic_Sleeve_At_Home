using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderFloatToText : MonoBehaviour
{
    Text floatText;
    void Start()
    {
        floatText = GetComponent<Text>();
    }
    public void SetSliderValue(float sliderValue)
    {
        floatText.text = sliderValue.ToString("F3");
    }
}
