using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnableDisableModels : MonoBehaviour
{
    public ToggleSwitch button;
    public GameObject modelLeft;
    public GameObject modelRight;
    public GameObject armSelect;
    public bool b_isTrunk;

    private bool b_enable;
    private bool b_dataLoaded;
    private bool b_firstFrame;
    private int i_arm;

    // Start is called before the first frame update
    void Start()
    {
        b_enable = true;
        b_dataLoaded = false;
        b_firstFrame = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(b_firstFrame)
        {
            StartCoroutine(WaitForDataLoadCoroutine());
        }

        b_enable = button.bOnOffSwitch;
        i_arm = armSelect.GetComponent<TMP_Dropdown>().value;

        if (b_isTrunk && b_dataLoaded)
        {
            if (b_enable)
            {
                modelLeft.SetActive(true);
                modelRight.SetActive(true);
            }
            else
            {
                modelRight.SetActive(false);
                modelLeft.SetActive(false);
            }
        }
        else if(!b_isTrunk && b_dataLoaded)
        {
            // if right arm selected
            if (i_arm == 0)
            {
                modelRight.SetActive(b_enable);
                modelLeft.SetActive(false);
            }
            else if (i_arm == 1) // if left arm selected
            {
                modelLeft.SetActive(b_enable);
                modelRight.SetActive(false);
            }
        }

        b_firstFrame = false;
    }

    IEnumerator WaitForDataLoadCoroutine()
    {
        yield return new WaitForSeconds(1);
        b_dataLoaded = true;
    }
}
