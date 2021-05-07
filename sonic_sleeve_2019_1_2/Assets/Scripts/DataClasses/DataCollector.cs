using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using System.Globalization;

public class DataCollector : MonoBehaviour
{
    public DataTracker dataTracker;

    private string filepath;
    private DateTime dateTime;
    private string currentTime;
    private string currentDate;

    // Start is called before the first frame update
    void Start()
    {
        if (dataTracker.ID == null)
        {
            filepath = "data.txt";
        }
        else
        {
            // filepath needs to save with user ID, condition and timestamp in filename
            currentTime = GetTime();
            currentDate = GetDate();
            filepath = dataTracker.ID + "_" + dataTracker.e_condition + "_" + currentDate + "_" + currentTime + ".txt";
        }

        AddHeader();
    }

    void AddHeader()
    {
        try
        {
            using (StreamWriter file = new StreamWriter(@filepath, true))
            {
                file.WriteLine("ID, date, timestamp, condition, elbow_comp, trunk_comp, shoulder_comp, pose_knn, cal_elbow, cal_trunk, cal_shoulder, block_n, rep_n, rep_ms, rep_error_ms, error_score, is_in_error, " +
                    "neck_x, neck_y, neck_z, " +
                    "shoulder_x, shoulder_y, shoulder_z, " +
                    "elbow_x, elbow_y, elbow_z, " +
                    "elbow_x, elbow_y, elbow_z, " +
                    "wrist_x, wrist_y, wrist_z, " +
                    "neck_x_raw, neck_y_raw, neck_z_raw, neck_quart_w_raw, neck_quart_x_raw, neck_quart_y_raw, neck_quart_z_raw, " +
                    "shoulder_x_raw, shoulder_y_raw, shoulder_z_raw, shoulder_quat_w_raw, shoulder_quat_x_raw, shoulder_quat_y_raw, shoulder_quat_z_raw" +
                    "elbow_x_raw, elbow_y_raw, elbow_z_raw, elbow_quart_w_raw, elbow_quart_x_raw, elbow_quart_y_raw, elbow_quart_z_raw, " +
                    "wrist_x_raw, wrist_y_raw, wrist_z_raw, wrist_quat_w_raw, wrist_quat_x_raw, wrist_quat_y_raw, wrist_quat_z_raw"
                    );
            }
        }
        catch (Exception ex)
        {
            throw new ApplicationException("File writing error: ", ex);
        }
    }

    void AddData(string id, string date, string time, string condition, float elbow_comp, float trunk_comp, float shoulder_comp, 
                int pose_knn, float cal_elbow, float cal_trunk, float cal_shoulder, int block_n, int rep_n, double rep_ms, double rep_error_ms, bool is_in_error,
                float neck_x, float neck_y, float neck_z, //with low pass filter
                float shoulder_x, float shoulder_y, float shoulder_z,
                float elbow_x, float elbow_y, float elbow_z, 
                float wrist_x, float wrist_y, float wrist_z, 
                float neck_x_raw, float neck_y_raw, float neck_z_raw, float neck_quart_w_raw, float neck_quart_x_raw, float neck_quart_y_raw, float neck_quart_z_raw,
                float shoulder_x_raw, float shoulder_y_raw, float shoulder_z_raw, float shoulder_quat_w_raw, float shoulder_quat_x_raw, float shoulder_quat_y_raw, float shoulder_quat_z_raw,
                float elbow_x_raw, float elbow_y_raw, float elbow_z_raw, float elbow_quart_w_raw, float elbow_quart_x_raw, float elbow_quart_y_raw, float elbow_quart_z_raw,
                float wrist_x_raw, float wrist_y_raw, float wrist_z_raw, float wrist_quat_w_raw, float wrist_quat_x_raw, float wrist_quat_y_raw, float wrist_quat_z_raw
                )
    {     
        try
        {
            using (StreamWriter file = new StreamWriter(@filepath, true))
            {
                file.WriteLine(id + ", " + date + ", " + time + ", " + condition + ", " + elbow_comp + ", " + trunk_comp + ", " + shoulder_comp + ", " + pose_knn + ", " + cal_elbow + ", " + cal_trunk + ", " + cal_shoulder + ", " + block_n + ", " + rep_n + ", " + rep_ms + ", " + rep_error_ms + ", " + is_in_error + ", " + 
                    neck_x + ", " + neck_y + ", " + neck_z + ", " + 
                    shoulder_x + ", " + shoulder_y + ", " + shoulder_z + ", " + 
                    elbow_x + ", " + elbow_y + ", " + elbow_z + ", " +
                    wrist_x + ", " + wrist_y + ", " + wrist_z + ", " +
                    neck_x_raw + ", " + neck_y_raw + ", " + neck_z_raw + ", " + neck_quart_w_raw + ", " + neck_quart_x_raw + ", " + neck_quart_y_raw + ", " + neck_quart_z_raw + ", " +
                    shoulder_x_raw + ", " + shoulder_y_raw + ", " + shoulder_z_raw + ", " + shoulder_quat_w_raw + ", " + shoulder_quat_x_raw + ", " + shoulder_quat_y_raw + ", " + shoulder_quat_z_raw + ", " +
                    elbow_x_raw + ", " + elbow_y_raw + ", " + elbow_z_raw + ", " + elbow_quart_w_raw + ", " + elbow_quart_x_raw + ", " + elbow_quart_y_raw + ", " + elbow_quart_z_raw + ", " +
                    wrist_x_raw + ", " + wrist_y_raw + ", " + wrist_z_raw + ", " + wrist_quat_w_raw + ", " + wrist_quat_x_raw + ", " + wrist_quat_y_raw + ", " + wrist_quat_z_raw
                    );
            }
        }
        catch(Exception ex)
        {
            throw new ApplicationException("File writing error: ", ex);
        }
    }

    public void WriteDataToFile()
    {
        currentTime = GetTime();
        currentDate = GetDate();

        AddData(dataTracker.ID, currentDate, currentTime, dataTracker.e_condition.ToString(), dataTracker.elbow_comp, dataTracker.trunk_comp, dataTracker.shoulder_comp, dataTracker.pose_knn, 
            dataTracker.cal_elbow, dataTracker.cal_trunk, dataTracker.cal_shoulder, dataTracker.block_n, dataTracker.rep_n, dataTracker.rep_ms, dataTracker.rep_error_ms, dataTracker.is_in_error, 
            dataTracker.neck_pos.x, dataTracker.neck_pos.y, dataTracker.neck_pos.z,
            dataTracker.shoulder_pos.x, dataTracker.shoulder_pos.y, dataTracker.shoulder_pos.z,
            dataTracker.elbow_pos.x, dataTracker.elbow_pos.y, dataTracker.elbow_pos.z,
            dataTracker.wrist_pos.x, dataTracker.wrist_pos.y, dataTracker.wrist_pos.z,
            dataTracker.neck_pos_raw.x, dataTracker.neck_pos_raw.y, dataTracker.neck_pos_raw.z, dataTracker.neck_rot_raw.w, dataTracker.neck_rot_raw.x, dataTracker.neck_rot_raw.y, dataTracker.neck_rot_raw.z,
            dataTracker.shoulder_pos_raw.x, dataTracker.shoulder_pos_raw.y, dataTracker.shoulder_pos_raw.z, dataTracker.shoulder_rot_raw.w, dataTracker.shoulder_rot_raw.x, dataTracker.shoulder_rot_raw.y, dataTracker.shoulder_rot_raw.z,
            dataTracker.elbow_pos_raw.x, dataTracker.elbow_pos_raw.y, dataTracker.elbow_pos_raw.z, dataTracker.elbow_rot_raw.w, dataTracker.elbow_rot_raw.x, dataTracker.elbow_rot_raw.y, dataTracker.elbow_rot_raw.z,
            dataTracker.wrist_pos_raw.x, dataTracker.wrist_pos_raw.y, dataTracker.wrist_pos_raw.z, dataTracker.wrist_rot_raw.w, dataTracker.wrist_rot_raw.x, dataTracker.wrist_rot_raw.y, dataTracker.wrist_rot_raw.z
            );
        //AddData("", "", dataTracker.e_condition.ToString(), dataTracker.rep_n, dataTracker.rep_ms, dataTracker.is_in_error, dataTracker.rep_error_ms, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f);
    }

    public string GetTime()
    {
        dateTime = DateTime.Now;
        string hourVal = dateTime.Hour.ToString();
        string minuteVal = dateTime.Minute.ToString();
        string secondVal = dateTime.Second.ToString();
        string milliVal = dateTime.Millisecond.ToString();
        return hourVal + "-" + minuteVal + "-" + secondVal + "-" + milliVal;
    }

    public string GetDate()
    {
        dateTime = DateTime.Now;
        string day = dateTime.Day.ToString();
        string month = dateTime.Month.ToString();
        string year = dateTime.Year.ToString();
        return day + "-" + month + "-" + year;
    }
}
