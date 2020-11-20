using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuiCanvasToggle : MonoBehaviour
{
    public GameObject canvas;
    private bool bGuiToggle;
    public void toggleGuiCanvas()
    {
        bGuiToggle = !bGuiToggle;
        canvas.SetActive(bGuiToggle);
        Debug.Log("Toggle GUI");
    }
}
