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

        //AddHeader();
    }

    void AddHeader()
    {
        try
        {
            using (StreamWriter file = new StreamWriter(@filepath, true))
            {
                file.WriteLine("ID, date, timestamp, condition, elbow_comp, trunk_comp, shoulder_comp, pose_knn, cal_elbow, cal_trunk, cal_shoulder, block_n, rep_counterTotal, rep_n, rep_ms, rep_error_ms, rep_optimum_ms, error_score, is_in_error, blocktime_ms, condition_ms, affected_arm, neck_x_raw, neck_y_raw, neck_z_raw, neck_quart_w_raw, neck_quart_x_raw, neck_quart_y_raw, neck_quart_z_raw, left_shoulder_x_raw, left_shoulder_y_raw, left_shoulder_z_raw, left_shoulder_quart_w_raw, left_shoulder_quart_x_raw, left_shoulder_quart_y_raw, left_shoulder_quart_z_raw, right_shoulder_x_raw, right_shoulder_y_raw, right_shoulder_z_raw, right_shoulder_quart_w_raw, right_shoulder_quart_x_raw, right_shoulder_quart_y_raw, right_shoulder_quart_z_raw, left_elbow_x_raw, left_elbow_y_raw, left_elbow_z_raw, left_elbow_quart_w_raw, left_elbow_quart_x_raw, left_elbow_quart_y_raw, left_elbow_quart_z_raw, right_elbow_x_raw, right_elbow_y_raw, right_elbow_z_raw, right_elbow_quart_w_raw, right_elbow_quart_x_raw, right_elbow_quart_y_raw, right_elbow_quart_z_raw, left_wrist_x_raw, left_wrist_y_raw, left_wrist_z_raw, left_wrist_quart_w_raw, left_wrist_quart_x_raw, left_wrist_quart_y_raw, left_wrist_quart_z_raw, right_wrist_x_raw, right_wrist_y_raw, right_wrist_z_raw, right_wrist_quart_w_raw, right_wrist_quart_x_raw, right_wrist_quart_y_raw, right_wrist_quart_z_raw");
            }
        }
        catch (Exception ex)
        {
            throw new ApplicationException("File writing error: ", ex);
        }
    }

    void AddData(string id, string date, string time, string condition, int rep_n, double rep_ms, bool is_in_error, double rep_error_ms, float neck_x_raw, float neck_y_raw, float neck_z_raw, float neck_quart_w_raw, float neck_quart_x_raw, float neck_quart_y_raw, float neck_quart_z_raw)
    {     
        try
        {
            using (StreamWriter file = new StreamWriter(@filepath, true))
            {
                file.WriteLine(id + ", " + date + ", " + time + ", " + condition + ", " + rep_n + ", " + rep_ms + ", " + is_in_error + ", " + rep_error_ms + ", " + neck_x_raw + ", " + neck_y_raw + ", " + neck_z_raw + ", " + neck_quart_w_raw + ", " + neck_quart_x_raw + ", " + neck_quart_y_raw + ", " + neck_quart_z_raw);
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

        AddData(dataTracker.ID, currentDate, currentTime, dataTracker.e_condition.ToString(), dataTracker.rep_n, dataTracker.rep_ms, dataTracker.is_in_error, dataTracker.rep_error_ms, dataTracker.neck_pos.x, dataTracker.neck_pos.y, dataTracker.neck_pos.z, dataTracker.neck_rot.w, dataTracker.neck_rot.x, dataTracker.neck_rot.y, dataTracker.neck_rot.z);
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
