using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IML_InterfaceControls : MonoBehaviour
{
    private int i_targetVal;
    private bool b_record;
    private bool b_train;
    private bool b_run;

    private void Start()
    {
        GUItoIML.knnTargetVal = 1;
        b_record = false;
        b_train = false;
        b_run = false;
        //print("START CALL");
    }

    private void Update()
    {
        GUItoIML.b_trainModel = false;
        if(b_train)
        {
            GUItoIML.b_trainModel = true;
            b_train = false;
        }

        /*GUItoIML.b_runModel = false;
        if(b_run)
        {
            GUItoIML.b_runModel = true;
            b_run = false;
        }*/
    }
    public void knnDropdown()
    {
        i_targetVal = gameObject.GetComponent<TMPro.TMP_Dropdown>().value;
        if (i_targetVal == 0)
        {
            i_targetVal = 1;
        }
        else if (i_targetVal == 1)
        {
            i_targetVal = 2;
        }
        GUItoIML.knnTargetVal = i_targetVal;
    }

    public void RecordData()
    {
        b_record = !b_record;
        GUItoIML.b_recordData = b_record;
        print("RECORD DATA");
    }

    public void TrainModel()
    {
        b_train = true;
    }

    public void RunModel()
    {
        b_run = !b_run;
        GUItoIML.b_runModel = b_run;
        print("RUN MODEL");
    }
}
