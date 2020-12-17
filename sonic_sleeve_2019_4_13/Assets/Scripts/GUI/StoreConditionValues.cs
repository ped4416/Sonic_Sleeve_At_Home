using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StoreConditionValues : MonoBehaviour
{
    public DataTracker dataTracker;
    public TMP_Dropdown conditionDropdown;

    // Start is called before the first frame update
    void Start()
    {
        conditionDropdown.value = PlayerPrefs.GetInt("Condition");
    }

    public void SetConditionEnum()
    {
        dataTracker.e_condition = (DataTracker.Condition)conditionDropdown.value;
        PlayerPrefs.SetInt("Condition", (int)dataTracker.e_condition);
    }
}
