using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveTrunkThreshVal : MonoBehaviour
{
    public GameObject trunkThreshSlider;
    public DataTracker dataTracker;

    public float f_trunkVal;

    // Start is called before the first frame update
    void Awake()
    {
        trunkThreshSlider.GetComponent<Slider>().value = PlayerPrefs.GetFloat("Trunk Leaning Threshold");
    }

    private void Update()
    {
        dataTracker.cal_trunk = trunkThreshSlider.GetComponent<Slider>().value;
    }

    public void SaveThreshVal()
    {
        f_trunkVal = trunkThreshSlider.GetComponent<Slider>().value;
        PlayerPrefs.SetFloat("Trunk Leaning Threshold", f_trunkVal);
    }
}
