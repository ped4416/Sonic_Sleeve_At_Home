using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepCounter : MonoBehaviour
{
    public KNN_Output i_classificationValue;
    public OnTenReps tenReps;
    public int i_repCount;

    private int i_prevVal;
    private int i_prevRep;

    // Start is called before the first frame update
    void Start()
    {
        i_repCount = 0;
        i_prevVal = 0;
        i_prevRep = 0;
    }

    // Update is called once per frame
    void Update()
    {
        int i_currentRep = i_repCount;
        int i_currentVal = i_classificationValue.i_knnOutputValue;
        if (i_currentVal == 1 && i_prevVal == 2) i_repCount += 1;
        if (i_currentRep != i_prevRep) print("Rep Number: " + i_repCount);
        i_prevRep = i_currentRep;
        i_prevVal = i_currentVal;

        if(i_repCount == 10)
        {
            tenReps.Raise();
            i_repCount = 0;
        }
    }
}
