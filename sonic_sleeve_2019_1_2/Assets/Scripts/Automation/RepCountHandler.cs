using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepCountHandler : MonoBehaviour
{
    public RepCounter repCounter;
    public OnTenReps tenReps;
    public On50Reps fiftyReps;
    //public BlockCount blockCount;
    public OnRepTimerStart repTimerStart;
    public OnRepTimerStop repTimerStop;
    public OnRepTimerReset repTimerReset;
    public OnRepTimeWrite repTimeWrite;
    public OnStartMusic startMusic;
    public RepTimerActive repTimerActive;
    public DataTracker dataTracker;

    private int i_prevRep;
    private bool b_isRest;
    private bool b_startPosition;
    private bool b_fiveSecTimerEnd;
    private bool b_10SecTimerEnd;
    private bool b_2MinTimerEnd;
    private int i_blockNumber;

    // Start is called before the first frame update
    void Start()
    {
        i_prevRep = 0;
        //blockCount.i_value = 1;
        i_blockNumber = 1;

        b_startPosition = false;
        b_fiveSecTimerEnd = false;
        b_isRest = true;
        b_10SecTimerEnd = false;
        b_2MinTimerEnd = false;
        repTimerActive.b_isActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(b_startPosition && b_fiveSecTimerEnd)
        {
            print("Rep Timer Start Block");
            repTimerStart.Raise();
            repTimerActive.b_isActive = true;
            startMusic.Raise();
            b_isRest = false;
            b_fiveSecTimerEnd = false;
            //blockCount.i_value = 1;
            i_blockNumber = 1;
            //print("Block Number: " + blockCount.i_value);
            print("Block Number: " + i_blockNumber);
            repCounter.Begin();
        }

        if(b_10SecTimerEnd && b_startPosition)
        {
            repTimerStart.Raise();
            repTimerActive.b_isActive = true;
            startMusic.Raise();
            b_10SecTimerEnd = false;
            b_isRest = false;
            //blockCount.i_value += 1;
            //print("Block Number: " + blockCount.i_value);
            i_blockNumber += 1;
            print("Block Number: " + i_blockNumber);
            repCounter.Begin();
        }

        if(b_2MinTimerEnd && b_startPosition)
        {
            repTimerStart.Raise();
            repTimerActive.b_isActive = true;
            startMusic.Raise();
            b_2MinTimerEnd = false;
            b_isRest = false;
            //blockCount.i_value = 1;
            //print("Block Number: " + blockCount.i_value);
            i_blockNumber = 1;
            print("Block Number: " + i_blockNumber);
            repCounter.Begin();
        }

        if (!b_isRest)
        {
            int i_currentRep = repCounter.i_repCount;
            if (i_currentRep != i_prevRep)
            {
                repTimerStop.Raise();
                repTimerActive.b_isActive = false;
                repTimerReset.Raise();
                repTimerStart.Raise();
                repTimerActive.b_isActive = true;
            }
            i_prevRep = i_currentRep;

            //if (repCounter.i_repCount > 10 && blockCount.i_value < 5)
            if (repCounter.i_repCount > 10 && i_blockNumber < 5)
            {
                tenReps.Raise();
                repTimerStop.Raise();
                repTimerActive.b_isActive = false;
                repTimerReset.Raise();
                b_startPosition = false;
            }
            //else if(repCounter.i_repCount > 10 && blockCount.i_value == 5)
            else if (repCounter.i_repCount > 10 && i_blockNumber == 5)
            {
                fiftyReps.Raise();
                repTimerStop.Raise();
                repTimerActive.b_isActive = false;
                repTimerReset.Raise();
                b_startPosition = false;
            }
        }
        dataTracker.block_n = i_blockNumber; //PDK TODO - throws a null error
    }

    public void DisableRepCounter()
    {
        repCounter.End();
        b_isRest = true;
    }

    public void SetPositionBool()
    {
        b_startPosition = true;
    }

    public void SetFiveSecTimerBool()
    {
        b_fiveSecTimerEnd = true;
        
    }

    public void Set10SecTimerBool()
    {
        b_10SecTimerEnd = true;
    }

    public void Set2MinTimerBool()
    {
        b_2MinTimerEnd = true;
    }
}
