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
    public TextMeshProUGUI intKnnText;
    //private int i_prevVal;
    // Start is called before the first frame update
    void Start()
    {
        //i_prevVal = 0;
        //intKnnText = GetComponent<TextMeshProUGUI>();  //gameObject.AddComponent<TextMeshProUGUI>(); // 
    }

    // Update is called once per frame
    void Update()
    {
        int i_currentVal;
        i_currentVal = i_knnOutputValue;
        //if (i_currentVal != i_prevVal) print("KNN Output = " + i_currentVal);
        /*if (GUItoIML.b_runModel)
        {*/
        intKnnText.text = i_currentVal.ToString("F0");
        //}
        
        //i_prevVal = i_currentVal;
    }
}
