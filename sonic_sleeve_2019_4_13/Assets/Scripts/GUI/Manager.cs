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
       //retrain all models upon load? 
       //canvas.SetActive(bGui);
       //Debug.Log("GUI Hidden");
    }

    public void Exit()
    {
        //add calls to stop and reset music
        //rest ML models? 
        print("CLOSE APP");
        Application.Quit();
    }
}


