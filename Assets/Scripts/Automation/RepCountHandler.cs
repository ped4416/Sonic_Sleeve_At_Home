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
    public OnRepTimerStart repTimerStart;
    public OnRepTimerStop repTimerStop;
    public OnRepTimerReset repTimerReset;
    public OnRepTimeWrite repTimeWrite;

    private int i_prevRep;
    private bool b_isRest;
    private bool b_startPosition;
    private bool b_fiveSecTimerEnd;
    private bool b_repTimerTrigger;

    // Start is called before the first frame update
    void Start()
    {
        blockCount.i_value = 1;
        b_startPosition = false;
        b_fiveSecTimerEnd = false;
        b_repTimerTrigger = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(b_startPosition && b_fiveSecTimerEnd && b_repTimerTrigger)
        {
            print("Rep Timer Start Block");
            repTimerStart.Raise();
            b_isRest = false;
            b_repTimerTrigger = false;
        }

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
                b_repTimerTrigger = true;
                b_startPosition = false;
            }
            else if(repCounter.i_repCount == 10 && blockCount.i_value == 5)
            {
                fiftyReps.Raise();
                repTimerStop.Raise();
                repCounter.i_repCount = 0;
                blockCount.i_value = 1;
                b_repTimerTrigger = true;
                b_startPosition = false;
            }
        }
    }

    public void DisableRepCounter()
    {
        repCounter.End();
        b_isRest = true;
    }

    /*public void EnableRepCounter()
    {
        repTimerStart.Raise();
        b_isRest = false;
    }*/

    public void SetPositionBool()
    {
        b_startPosition = true;
    }

    public void SetFiveSecTimerBool()
    {
        b_fiveSecTimerEnd = true;
        repCounter.i_repCount = 0;
        blockCount.i_value = 1;
    }
}
