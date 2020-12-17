using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderFloatToText : MonoBehaviour
{
    //Text floatText;
    public TextMeshProUGUI floatText;
    void Start()
    {
        floatText = GetComponent<TextMeshProUGUI>();
    }
    public void SetSliderValue(float sliderValue)
    {
        floatText.text = sliderValue.ToString("F3");
    }
}
