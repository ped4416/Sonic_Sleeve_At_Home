using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class ClearBtn : MonoBehaviour
{

    public void Click()
    {
        GetComponent<Image>().color = Color.red;
        Debug.Log("Clear Button Pressed");
    }
}
