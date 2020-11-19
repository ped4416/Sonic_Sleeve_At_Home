using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisable : MonoBehaviour
{
    public GameObject button;
    public GameObject knn;

    private bool b_enable;
    // Start is called before the first frame update
    void Start()
    {
        b_enable = true;
    }

    // Update is called once per frame
    void Update()
    {
        b_enable = button.GetComponent<ToggleSwitch>().bOnOffSwitch;
        if(b_enable)
        {
            knn.SetActive(true);
        }
        else
        {
            knn.SetActive(false);
        }
    }
}
