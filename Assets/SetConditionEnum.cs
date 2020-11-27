using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetConditionEnum : MonoBehaviour
{
    public DataTracker dataTracker;

    public void SetEnum()
    {
        dataTracker.e_condition = DataTracker.Condition.Practice;
    }
}
