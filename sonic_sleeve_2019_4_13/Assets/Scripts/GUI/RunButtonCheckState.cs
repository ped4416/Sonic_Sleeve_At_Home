using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunButtonCheckState : MonoBehaviour
{
    public GameObject imlControls;
    public GameObject changeText;

    private bool b_isRunning;

    // Start is called before the first frame update
    void Start()
    {
        b_isRunning = false;
    }

    // Update is called once per frame
    public void ActivateRunButton()
    {
        if(!b_isRunning)
        {
            imlControls.GetComponent<IML_InterfaceControls>().RunModel();
            changeText.GetComponent<RunStopChangeText>().changeText();
            b_isRunning = !b_isRunning;
        }
    }

    public void SetBool()
    {
        b_isRunning = !b_isRunning;
    }
}
