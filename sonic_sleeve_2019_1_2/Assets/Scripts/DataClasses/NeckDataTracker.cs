using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeckDataTracker : MonoBehaviour
{
    public DataTracker dataTracker;
    public Vec3LowPassFilter vecFilter;
    public bool b_filterOn;

    void Update()
    {
            dataTracker.neck_pos = vecFilter.dataOut;            
            //dataTracker.neck_rot = quatFilter.dataOut;
        
            dataTracker.neck_pos_raw = gameObject.GetComponent<Vec3LowPassFilter>().rawDataOut;
            dataTracker.neck_rot_raw = gameObject.transform.rotation;
            //print("Neck Pos: " + dataTracker.neck_pos + "   ::  Neck Rot: " + dataTracker.neck_rot);
    }
}
