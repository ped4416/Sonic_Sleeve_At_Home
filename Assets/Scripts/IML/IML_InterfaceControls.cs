﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IML_InterfaceControls : MonoBehaviour
{
    private int i_targetVal;
    private bool b_record;
    private bool b_train;
    private bool b_run;
    private float f_boundVal;
    
    private void Start()
    {
        GUItoIML.knnTargetVal = 1;
        f_boundVal = 0.0f;
        b_record = false;
        b_train = false;
        b_run = false;
        //print("START CALL");
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
        GUItoIML.b_trainModel = true;
        //print("TRAINMODEL CALL");
        //b_train = true;
    }

    public void RunModel()
    {
        b_run = !b_run;
        GUItoIML.b_runModel = b_run;
        print("RUN MODEL");
    }

    public void SetBounds()
    {
        if (!b_run)
        {
            f_boundVal = gameObject.GetComponent<Slider>().value;
            GUItoIML.f_boundaryValue = f_boundVal;
        }
    }

    public void DeleteExamples()
    {
        GUItoIML.b_deleteExamples = true;
    }
}