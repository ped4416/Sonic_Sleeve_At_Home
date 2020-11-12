using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepCounter : MonoBehaviour
{
    public KNN_Output i_classificationValue;
    public OnTenReps tenReps;
    public On50Reps fiftyReps;
    public BlockCount blockCount;
    public OnRestStartListener restStartListener;
    public OnPositionFoundListener positionFoundListener;
    public OnStopwatchStart repTimerStart;
    public OnStopwatchStop repTimerStop;
    public OnStopwatchStart blockTimerStart;
    public OnStopwatchStop blockTimerStop;
    public OnStopwatchStop errorTimerStop;
    public int i_repCount;

    private int i_prevVal;
    private int i_prevRep;
    private bool b_isRest;

    // Start is called before the first frame update
    void Start()
    {
        i_repCount = 0;
        i_prevVal = 0;
        i_prevRep = 0;
        blockCount.i_value = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (!b_isRest)
        {
            int i_currentRep = i_repCount;
            int i_currentVal = i_classificationValue.i_knnOutputValue;
            if (i_currentVal == 1 && i_prevVal == 2)
            {
                i_repCount += 1;
                errorTimerStop.Raise();
                repTimerStop.Raise();
                repTimerStart.Raise();
            }
            if (i_currentRep != i_prevRep) print("Rep Number: " + i_repCount + "    ||  Block Number: " + blockCount.i_value);
            i_prevRep = i_currentRep;
            i_prevVal = i_currentVal;

            if (i_repCount == 10 && blockCount.i_value < 5)
            {
                tenReps.Raise();
                errorTimerStop.Raise();
                repTimerStop.Raise();
                blockTimerStop.Raise();
                i_repCount = 0;
                blockCount.i_value += 1;
            }
            else if(i_repCount == 10 && blockCount.i_value == 5)
            {
                fiftyReps.Raise();
                errorTimerStop.Raise();
                repTimerStop.Raise();
                blockTimerStop.Raise();
                i_repCount = 0;
                blockCount.i_value = 1;
            }
        }
    }

    public void DisableRepCounter()
    {
        b_isRest = true;
    }

    public void EnableRepCounter()
    {
        blockTimerStart.Raise();
        repTimerStart.Raise();
        b_isRest = false;
    }
}
