using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveTrunkThreshVal : MonoBehaviour
{
    public GameObject trunkThreshSlider;

    public float f_trunkVal;

    // Start is called before the first frame update
    void Awake()
    {
        trunkThreshSlider.GetComponent<Slider>().value = PlayerPrefs.GetFloat("Trunk Leaning Threshold");
    }

    public void SaveThreshVal()
    {
        f_trunkVal = trunkThreshSlider.GetComponent<Slider>().value;
        PlayerPrefs.SetFloat("Trunk Leaning Threshold", f_trunkVal);
    }
}
