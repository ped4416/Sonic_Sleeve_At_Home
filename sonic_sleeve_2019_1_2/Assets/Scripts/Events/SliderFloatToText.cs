using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderFloatToText : MonoBehaviour
{
    //Text floatText;
    public TextMeshProUGUI floatText;
    public GameObject slider;

    void Start()
    {
        floatText = GetComponent<TextMeshProUGUI>();
    }
    //public void SetSliderValue(float sliderValue)
    public void SetSliderValue()
    {
        floatText.text = slider.GetComponent<Slider>().value.ToString("F3");
        //floatText.text = sliderValue.ToString("F3");
    }
}
