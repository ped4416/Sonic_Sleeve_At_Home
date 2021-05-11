using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InteractML;
using UnityEngine.UI;
using TMPro;

public class KNN_Output : MonoBehaviour
{
    [PullFromIMLController]
    public int i_knnOutputValue;
    public int i_constrainedKNNValue;
    public GameObject intKnnText;
    public DataTracker dataTracker;
    public StopwatchTimer constraintTimer;

    private bool b_timerOn;
    private int i_prevKNNVal;
    private float f_constraintThresh;


    private void Start()
    {
        b_timerOn = false;
        f_constraintThresh = 0.5f;
        i_prevKNNVal = 1;
    }

    // Update is called once per frame
    void Update()
    {
        intKnnText.GetComponent<TextMeshProUGUI>().text = i_knnOutputValue.ToString("F0");

        if (b_timerOn)
        {
            
            int i_currentKNNVal = i_knnOutputValue;

            if (i_currentKNNVal != i_prevKNNVal)
            {
                double timerVal = constraintTimer.GetTimeSeconds();
                if(timerVal >= f_constraintThresh)
                {
                    i_constrainedKNNValue = i_currentKNNVal;   
                    dataTracker.pose_knn = i_constrainedKNNValue;
                    ResetConstraintTimer();
                }    
            }
            i_prevKNNVal = i_currentKNNVal;
        }
    }

    public void StartConstraintTimer()
    {
        constraintTimer.StartTimer();
        b_timerOn = true;
    }

    public void StopConstraintTimer()
    {
        constraintTimer.StopTimer();
        b_timerOn = false;
    }

    public void ResetConstraintTimer()
    {
        constraintTimer.ResetTimer();
        constraintTimer.RestartTimer();
    }
}
