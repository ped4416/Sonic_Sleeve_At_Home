using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InteractML;

public class ShoulderAbductionOutput : MonoBehaviour
{
    [PullFromIMLController]
    public float f_MLPOutputValue;

    private float f_prevVal;
    // Start is called before the first frame update
    void Start()
    {
        f_prevVal = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        float f_currentVal;

        f_currentVal = f_MLPOutputValue;
        if (f_currentVal != f_prevVal) print("Shoulder Abduction Output = " + f_currentVal);
        f_prevVal = f_currentVal;
    }
}
