﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InteractML;
using UnityEngine.UI;
using TMPro;

public class KNN_Output : MonoBehaviour
{
    [PullFromIMLController]
    public int i_knnOutputValue;
    public GameObject intKnnText;
    public DataTracker dataTracker;

    // Update is called once per frame
    void Update()
    {
        intKnnText.GetComponent<TextMeshProUGUI>().text = i_knnOutputValue.ToString("F0");
        dataTracker.pose_knn = i_knnOutputValue;
    }
}
