using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public GameObject canvas;
    private bool bGui = true;
    void Start()
    {
       canvas.SetActive(bGui);
       Debug.Log("GUI Hidden");
    }
}
