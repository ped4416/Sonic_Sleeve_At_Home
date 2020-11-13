using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleSwitch : MonoBehaviour
{
    public GameObject switchOn, switchOff;

    public void OnChangeValue()
    {
        bool bOnOffSwitch = gameObject.GetComponent<Toggle>().isOn;

        if (bOnOffSwitch)
        {
            Debug.Log("Switch On");
            switchOn.SetActive(true);
            switchOff.SetActive(false);
        }
        
        if (!bOnOffSwitch)
        { 
            Debug.Log("Switch Off");
            switchOn.SetActive(false);
            switchOff.SetActive(true);
        
        }
    }
}
