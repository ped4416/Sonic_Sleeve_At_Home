using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class DataTracker : ScriptableObject
{
    public double rep_ms;
    public double rep_error_ms; 
    // consider adding in smoothed data not just raw data as below
    public Vector3 neck_pos;
    public Quaternion neck_rot;
    public Vector3 left_shoulder_pos;
    public Quaternion left_shoulder_rot;
    public Vector3 right_shoulder_pos;
    public Quaternion right_shoulder_rot;
    public Vector3 left_elbow_pos;
    public Quaternion left_elbow_rot;
    public Vector3 right_elbow_pos;
    public Quaternion right_elbow_rot;
    public Vector3 left_wrist_pos;
    public Quaternion left_wrist_rot;
    public Vector3 right_wrist_pos;
    public Quaternion right_wrist_rot;

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
