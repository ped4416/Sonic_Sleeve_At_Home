using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class DataCollector : MonoBehaviour
{
    public RepMs repTime;

    private string filepath;
    // Start is called before the first frame update
    void Start()
    {
        filepath = "data.txt";
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            AddData("test", "12/11/2020", repTime.rep_ms);
        }
    }

    void AddData(string id, string date, float rep_ms)
    {
        try
        {
            using (StreamWriter file = new StreamWriter(@filepath, true))
            {
                file.WriteLine(id + ", " + date + ", " + rep_ms);
            }
        }
        catch(Exception ex)
        {
            throw new ApplicationException("File writing error: ", ex);
        }
    }
}
