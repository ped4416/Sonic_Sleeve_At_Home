﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TextBtn : MonoBehaviour
{
    public Text mytext = null;
    public int counter = 0;
    public void changeText()
    {
        counter++;
        if (counter % 2 == 1)
        {
            mytext.color = Color.red;
            mytext.text = "Stop Recording";  
        }
        else
        {
            mytext.color = Color.black;
            mytext.text = "Start Recording";
        }
    }
}