﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisableGUIs : MonoBehaviour
{
    public GameObject setupGUI;
    public GameObject menuGUI;
    public GameObject runGUI;

    private bool b_setupGUI;
    private bool b_menuGUI;
    private bool b_runGUI;
    
    // Start is called before the first frame update
    void Start()
    {
        b_setupGUI = false;
        b_menuGUI = true;
        b_runGUI = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(b_runGUI && !b_menuGUI)
        {
            runGUI.SetActive(true);
            menuGUI.SetActive(false);   
        }
        else if (!b_runGUI && b_menuGUI)
        {
            runGUI.SetActive(false);
            menuGUI.SetActive(true);
        }

        if(b_setupGUI)
        {
            setupGUI.SetActive(true);
            if(b_menuGUI)
            {
                menuGUI.SetActive(false);
            }
        }
        else
        {
            setupGUI.SetActive(false);
        }
        
    }

    public void ShowRunGUI()
    {
        print("RUN GUI EVENT");
        b_runGUI = true;
        b_menuGUI = false;
    }

    public void ShowToggleSetupGUI()
    {
        print("SETUP TOGGLE EVENT");
        b_setupGUI = !b_setupGUI;
    }
}