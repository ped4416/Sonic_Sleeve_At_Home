using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepCountHandler : MonoBehaviour
{
    public RepCounter repCounter;
    public OnTenReps tenReps;
    public On50Reps fiftyReps;
    public BlockCount blockCount;
    public OnRestStartListener restStartListener;
    public OnPositionFoundListener positionFoundListener;
    public OnRepTimerStart repTimerStart;
    public OnRepTimerStop repTimerStop;
    public OnRepTimerReset repTimerReset;
    public OnRepTimeWrite repTimeWrite;

    private int i_prevRep;
    private bool b_isRest;

    // Start is called before the first frame update
    void Start()
    {
        blockCount.i_value = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (!b_isRest)
        {
            repCounter.Begin();
            int i_currentRep = repCounter.i_repCount;
            if (i_currentRep != i_prevRep)
            {
                repTimerStop.Raise();
                repTimerReset.Raise();
                repTimerStart.Raise();
            }
            i_prevRep = i_currentRep;

            if (repCounter.i_repCount == 10 && blockCount.i_value < 5)
            {
                tenReps.Raise();
                repTimerStop.Raise();
                repCounter.i_repCount = 0;
                blockCount.i_value += 1;
                print("Block Number: " + blockCount.i_value);
            }
            else if(repCounter.i_repCount == 10 && blockCount.i_value == 5)
            {
                fiftyReps.Raise();
                repTimerStop.Raise();
                repCounter.i_repCount = 0;
                blockCount.i_value = 1;
            }
        }
    }

    public void DisableRepCounter()
    {
        repCounter.End();
        b_isRest = true;
    }

    public void EnableRepCounter()
    {
        repTimerStart.Raise();
        b_isRest = false;
    }
}
