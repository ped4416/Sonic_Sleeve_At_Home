﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class DataTracker : ScriptableObject
{
    public double rep_ms;
    public double rep_error_ms;
    public Vector3 neck_pos;
    public Quaternion neck_rot;

    public enum Condition
    { 
        Control,
        Experimental,
        Practice
    }

    public Condition e_condition;

}