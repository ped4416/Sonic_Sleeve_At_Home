using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasTest : MonoBehaviour
{
    public bool canvasOn;

    // Start is called before the first frame update
    void Start()
    {
        canvasOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            canvasOn = !canvasOn;
        }
    }
}
