using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisable : MonoBehaviour
{
    public CanvasTest button;
    public GameObject canvas;

    private bool b_enable;
    // Start is called before the first frame update
    void Start()
    {
        b_enable = true;
    }

    // Update is called once per frame
    void Update()
    {
        b_enable = button.canvasOn;
        //b_enable = button.GetComponent<ToggleSwitch>().bOnOffSwitch;
        if(b_enable)
        {
            canvas.SetActive(true);
        }
        else
        {
            canvas.SetActive(false);
        }
    }
}
