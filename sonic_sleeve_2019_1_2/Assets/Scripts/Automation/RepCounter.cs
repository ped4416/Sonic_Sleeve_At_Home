using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RepCounter : MonoBehaviour
{
    public GameObject KNN_Output;
    public int i_repCount;

    private int i_prevVal;
    private int i_prevRep;
    private bool b_active;
    public TextMeshProUGUI intCurrentRepText;

    // Start is called before the first frame update
    void Start()
    {
        i_repCount = 0;
        i_prevVal = 0;
        i_prevRep = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(b_active)
        {
            int i_currentRep = i_repCount;
            int i_currentVal = KNN_Output.GetComponent<ModelController>().i_knnVal;
            if (i_currentVal == 1 && i_prevVal == 2)
            {
                i_repCount += 1;
            }
            if (i_currentRep != i_prevRep) print("Rep Number: " + i_repCount);
            i_prevRep = i_currentRep;
            i_prevVal = i_currentVal;
            intCurrentRepText.text = i_repCount.ToString("F0");
        }
    }

    public void Begin()
    {
        b_active = true;
        i_repCount = 0;
        i_prevRep = 0;
    }

    public void End()
    {
        b_active = false;
    }
}
