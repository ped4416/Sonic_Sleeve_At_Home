using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KNN_InterfaceControls : MonoBehaviour
{
    public GameObject knnDropdown;

    private int targetVal;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        targetVal = knnDropdown.GetComponent<TMPro.TMP_Dropdown>().value;
        if(targetVal == 0)
        {
            targetVal = 1;
        }
        else if(targetVal == 1)
        {
            targetVal = 2;
        }
        KnnTargets.targetVal = targetVal;
    }
}
