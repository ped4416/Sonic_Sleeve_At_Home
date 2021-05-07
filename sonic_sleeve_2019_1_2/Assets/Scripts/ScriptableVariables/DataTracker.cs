using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class DataTracker : ScriptableObject
{
    public double rep_ms;
    public double rep_error_ms; 
    // smoothed data used prior to auditory feedback 
    public Vector3 neck_pos;
    public Vector3 shoulder_pos;
    public Vector3 elbow_pos;
    public Vector3 wrist_pos;
    //public Quaternion neck_rot;
    //all raw data 3D and quaternians
    public Vector3 neck_pos_raw;
    public Quaternion neck_rot_raw;
    public Vector3 shoulder_pos_raw;
    public Quaternion shoulder_rot_raw;
    public Vector3 elbow_pos_raw;
    public Quaternion elbow_rot_raw;
    public Vector3 wrist_pos_raw;
    public Quaternion wrist_rot_raw;
    public enum Condition
    { 
        Control,
        Experimental,
        Practice
    }

    public Condition e_condition;
    public int rep_n;
    public bool is_in_error;
    public string ID;
    public float elbow_comp;
    public float trunk_comp;
    public float shoulder_comp;
    public int pose_knn;
    public float cal_elbow;
    public float cal_trunk;
    public float cal_shoulder;
    public int block_n;

}
