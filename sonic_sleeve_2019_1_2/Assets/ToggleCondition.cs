using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ToggleCondition : MonoBehaviour
{
    public TMP_Dropdown dropdown;

    public void ToggleConditionValue()
    {
        int prevState = dropdown.value;
        int currentState;

        if(prevState == 0)
        {
            currentState = 1;
        }
        else
        {
            currentState = 0;
        }

        dropdown.value = currentState;
    }
}
