using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class DataCollector : MonoBehaviour
{
    public RepMs repTime;
    public RepError repErr;

    private string filepath;
    private bool b_writeData;

    // Start is called before the first frame update
    void Start()
    {
        filepath = "data.txt";
        b_writeData = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(b_writeData)
        {
            AddData("test", "12/11/2020", repTime.rep_ms, repErr.rep_error_ms);
            b_writeData = false;
        }
        
    }

    void AddData(string id, string date, float rep_ms, float rep_error_ms)
    {
        try
        {
            using (StreamWriter file = new StreamWriter(@filepath, true))
            {
                file.WriteLine(id + ", " + date + ", " + rep_ms + ", " + rep_error_ms);
            }
        }
        catch(Exception ex)
        {
            throw new ApplicationException("File writing error: ", ex);
        }
    }

    public void WriteDataToFile()
    {
        b_writeData = true;
    }
}
