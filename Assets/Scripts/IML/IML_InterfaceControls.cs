using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IML_InterfaceControls : MonoBehaviour
{
    public GameObject knnDropdown;
    public GameObject recordButton;

    private int i_targetVal;
    private bool b_record;

    // Update is called once per frame
    void Update()
    {
        i_targetVal = knnDropdown.GetComponent<TMPro.TMP_Dropdown>().value;
        if(i_targetVal == 0)
        {
            i_targetVal = 1;
        }
        else if(i_targetVal == 1)
        {
            i_targetVal = 2;
        }
        GUItoIML.knnTargetVal = i_targetVal;
    }
}
