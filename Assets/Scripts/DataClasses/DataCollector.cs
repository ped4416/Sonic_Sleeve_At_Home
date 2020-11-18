using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class DataCollector : MonoBehaviour
{
    public DataTracker dataTracker;

    private string filepath;

    // Start is called before the first frame update
    void Start()
    {
        filepath = "data.txt";
    }

    void AddData(string id, string date, double rep_ms, float neck_x_raw, float neck_y_raw, float neck_z_raw, float neck_quart_w_raw, float neck_quart_x_raw, float neck_quart_y_raw, float neck_quart_z_raw)
    {
        try
        {
            using (StreamWriter file = new StreamWriter(@filepath, true))
            {
                file.WriteLine(id + ", " + date + ", " + rep_ms + ", " + neck_x_raw + ", " + neck_y_raw + ", " + neck_z_raw + ", " + neck_quart_w_raw + ", " + neck_quart_x_raw + ", " + neck_quart_y_raw + ", " + neck_quart_z_raw);
            }
        }
        catch(Exception ex)
        {
            throw new ApplicationException("File writing error: ", ex);
        }
    }

    public void WriteDataToFile()
    {
        AddData("test", "18/11/2020", dataTracker.rep_ms, dataTracker.neck_pos.x, dataTracker.neck_pos.y, dataTracker.neck_pos.z, dataTracker.neck_rot.w, dataTracker.neck_rot.x, dataTracker.neck_rot.y, dataTracker.neck_rot.z);
    }
}
