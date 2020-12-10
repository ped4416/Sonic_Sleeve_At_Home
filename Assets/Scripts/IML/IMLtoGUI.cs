using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IMLtoGUI : MonoBehaviour
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

    private int i_arm;
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
}
