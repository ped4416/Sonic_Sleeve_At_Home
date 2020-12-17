using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetupGUIToggle : MonoBehaviour
{
    public GameObject canvas;
    private bool bGuiToggle;
    public void toggleGuiCanvas()
    {
        bGuiToggle = !bGuiToggle;
        canvas.SetActive(bGuiToggle);
    }
}
