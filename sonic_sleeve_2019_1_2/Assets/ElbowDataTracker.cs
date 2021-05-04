using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElbowDataTracker : MonoBehaviour
{
    public DataTracker dataTracker;
    public Vec3LowPassFilter vecFilter;

    void Update()
    {
        dataTracker.elbow_pos = vecFilter.dataOut;

        dataTracker.elbow_pos_raw = gameObject.GetComponent<Vec3LowPassFilter>().rawDataOut;
        dataTracker.elbow_rot_raw = gameObject.transform.rotation;
    }
}
