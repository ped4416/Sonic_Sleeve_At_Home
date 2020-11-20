using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IML_InterfaceControls : MonoBehaviour
{
    //public GameObject guiElement;

    private int i_targetVal;

    private void Start()
    {
        GUItoIML.knnTargetVal = 1;
    }

    public void knnDropdown()
    {
        i_targetVal = gameObject.GetComponent<TMPro.TMP_Dropdown>().value;
        if (i_targetVal == 0)
        {
            i_targetVal = 1;
        }
        else if (i_targetVal == 1)
        {
            i_targetVal = 2;
        }
        GUItoIML.knnTargetVal = i_targetVal;
    }

    /*void RecordData()
    {

    }*/
}
