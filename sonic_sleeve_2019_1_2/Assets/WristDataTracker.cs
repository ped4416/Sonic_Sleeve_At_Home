using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WristDataTracker : MonoBehaviour
{
    public DataTracker dataTracker;
    public Vec3LowPassFilter vecFilter;

    void Update()
    {
        dataTracker.wrist_pos = vecFilter.dataOut;

        dataTracker.wrist_pos_raw = gameObject.GetComponent<Vec3LowPassFilter>().rawDataOut;
        dataTracker.wrist_rot_raw = gameObject.transform.rotation;
    }
}
