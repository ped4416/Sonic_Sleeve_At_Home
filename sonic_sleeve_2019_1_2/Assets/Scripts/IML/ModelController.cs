using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ModelController : MonoBehaviour
{
    public GameObject knnRight;
    public GameObject knnLeft;
    public GameObject shoulderAbductionRight;
    public GameObject shoulderAbductionLeft;
    public GameObject shoulderElevationRight;
    public GameObject shoulderElevationLeft;
    public GameObject trunkLeaning;
    public GameObject armDropdown;
    public GameObject knnEnableRecordButton;
    public GameObject elbowEnableRecordButton;
    public GameObject trunkEnableRecordButton;
    public GameObject shoulderEnableRecordButton;
    public GameObject knnTargetValDropdown;

    private int i_arm;
    private int i_targetVal;
    private bool knnOn;
    private bool elbowOn;
    private bool shoulderOn;
    private bool trunkOn;

    // Update is called once per frame
    void Update()
    {
        i_arm = armDropdown.GetComponent<TMP_Dropdown>().value;
        knnOn = knnEnableRecordButton.GetComponent<ToggleSwitch>().bOnOffSwitch;
        elbowOn = elbowEnableRecordButton.GetComponent<ToggleSwitch>().bOnOffSwitch;
        shoulderOn = shoulderEnableRecordButton.GetComponent<ToggleSwitch>().bOnOffSwitch;
        trunkOn = trunkEnableRecordButton.GetComponent<ToggleSwitch>().bOnOffSwitch;

        ModelOutput();
    }

    public void RecordData()
    {
        if(i_arm == 0)
        {
            if (knnOn) knnRight.GetComponent<KNNNodeAccess>().KNNRecord();
            if (elbowOn) shoulderAbductionRight.GetComponent<MLPNodeAccess>().MLPRecord();
            if (shoulderOn) shoulderElevationRight.GetComponent<MLPNodeAccess>().MLPRecord();
        }
        else if(i_arm == 1)
        {
            if (knnOn) knnLeft.GetComponent<KNNNodeAccess>().KNNRecord();
            if (elbowOn) shoulderAbductionLeft.GetComponent<MLPNodeAccess>().MLPRecord();
            if (shoulderOn) shoulderElevationLeft.GetComponent<MLPNodeAccess>().MLPRecord();
        }

        if (trunkOn) trunkLeaning.GetComponent<MLPNodeAccess>().MLPRecord();
    }

    public void UpdateKNNTargetValue()
    {
        i_targetVal = knnTargetValDropdown.GetComponent<TMP_Dropdown>().value;
        if (i_targetVal == 0)
        {
            i_targetVal = 1;
        }
        else if (i_targetVal == 1)
        {
            i_targetVal = 2;
        }

        if (i_arm == 0)
        {
            knnRight.GetComponent<KNNNodeAccess>().KNNTargetValue(i_targetVal);
        }
        else if (i_arm == 1)
        {
            knnLeft.GetComponent<KNNNodeAccess>().KNNTargetValue(i_targetVal);
        }
    }

    public void TrainModels()
    {
        if (i_arm == 0)
        {
            if (knnOn) knnRight.GetComponent<KNNNodeAccess>().KNNTrain();
            if (elbowOn) shoulderAbductionRight.GetComponent<MLPNodeAccess>().MLPTrain();
            if (shoulderOn) shoulderElevationRight.GetComponent<MLPNodeAccess>().MLPTrain();
        }
        else if (i_arm == 1)
        {
            if (knnOn) knnLeft.GetComponent<KNNNodeAccess>().KNNTrain();
            if (elbowOn) shoulderAbductionLeft.GetComponent<MLPNodeAccess>().MLPTrain();
            if (shoulderOn) shoulderElevationLeft.GetComponent<MLPNodeAccess>().MLPTrain();
        }

        if (trunkOn) trunkLeaning.GetComponent<MLPNodeAccess>().MLPTrain();
    }

    public void RunModels()
    {
        if (i_arm == 0)
        {
            if (knnOn) knnRight.GetComponent<KNNNodeAccess>().KNNRun();
            if (elbowOn) shoulderAbductionRight.GetComponent<MLPNodeAccess>().MLPRun();
            if (shoulderOn) shoulderElevationRight.GetComponent<MLPNodeAccess>().MLPRun();
        }
        else if (i_arm == 1)
        {
            if (knnOn) knnLeft.GetComponent<KNNNodeAccess>().KNNRun();
            if (elbowOn) shoulderAbductionLeft.GetComponent<MLPNodeAccess>().MLPRun();
            if (shoulderOn) shoulderElevationLeft.GetComponent<MLPNodeAccess>().MLPRun();
        }

        if (trunkOn) trunkLeaning.GetComponent<MLPNodeAccess>().MLPRun();
    }

    void ModelOutput()
    {
        if (i_arm == 0)
        {
            if (knnOn)
            {
                knnRight.GetComponent<KNN_Output>().enabled = true;
                knnLeft.GetComponent<KNN_Output>().enabled = false;
            }

            if (elbowOn)
            {
                shoulderAbductionRight.GetComponent<ShoulderAbductionOutput>().enabled = true;
                shoulderAbductionLeft.GetComponent<ShoulderAbductionOutput>().enabled = false;
            }

            if (shoulderOn)
            {
                shoulderElevationRight.GetComponent<ShoulderElevationOutput>().enabled = true;
                shoulderElevationLeft.GetComponent<ShoulderElevationOutput>().enabled = false;
            }

        }
        else if (i_arm == 1)
        {
            if (knnOn)
            {
                knnRight.GetComponent<KNN_Output>().enabled = false;
                knnLeft.GetComponent<KNN_Output>().enabled = true;
            }

            if (elbowOn)
            {
                shoulderAbductionRight.GetComponent<ShoulderAbductionOutput>().enabled = false;
                shoulderAbductionLeft.GetComponent<ShoulderAbductionOutput>().enabled = true;
            }

            if (shoulderOn)
            {
                shoulderElevationRight.GetComponent<ShoulderElevationOutput>().enabled = false;
                shoulderElevationLeft.GetComponent<ShoulderElevationOutput>().enabled = true;
            }
        }  
    }
}
