using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeckDataTracker : MonoBehaviour
{
    public DataTracker dataTracker;
    public Vec3LowPassFilter vecFilter;
    public QuaternionLowPassFilter quatFilter;
    public bool b_filterOn;

    void Update()
    {
        if(b_filterOn)
        {
            dataTracker.neck_pos = vecFilter.dataOut;
            dataTracker.neck_rot = quatFilter.dataOut;
        }
        else
        {
            dataTracker.neck_pos = gameObject.transform.position;
            dataTracker.neck_rot = gameObject.transform.rotation;
            //print("Neck Pos: " + dataTracker.neck_pos + "   ::  Neck Rot: " + dataTracker.neck_rot);
        }
        
    }
}
