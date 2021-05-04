using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoulderDataTracker : MonoBehaviour
{
    public DataTracker dataTracker;
    public Vec3LowPassFilter vecFilter;

    void Update()
    {
        dataTracker.shoulder_pos = vecFilter.dataOut;

        dataTracker.shoulder_pos_raw = gameObject.GetComponent<Vec3LowPassFilter>().rawDataOut;
        dataTracker.shoulder_rot_raw = gameObject.transform.rotation;
    }
}
