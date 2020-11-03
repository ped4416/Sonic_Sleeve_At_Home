using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InteractML;

public class KNN_Output : MonoBehaviour
{
    [PullFromIMLController]
    public int i_knnOutputValue;

    private int i_prevVal;
    // Start is called before the first frame update
    void Start()
    {
        i_prevVal = 0;
    }

    // Update is called once per frame
    void Update()
    {
        int i_currentVal;

        i_currentVal = i_knnOutputValue;
        if (i_currentVal != i_prevVal) print("KNN Output = " + i_currentVal);
        i_prevVal = i_currentVal;
    }
}
