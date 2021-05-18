using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ErrorTimerActive : ScriptableObject
{
    public bool b_elbowActive;
    public bool b_shoulderActive;
    public bool b_trunkActive;

    public bool CheckModelError()
    {
        if(b_elbowActive || b_shoulderActive || b_trunkActive)
        {
            return true;
        }

        return false;
    }
}
