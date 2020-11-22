using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using TMPro;

public class GetStartPosition : MonoBehaviour
{

    public Transform rightShoulder;
    public Transform leftShoulder;
    public Transform neck;
    public Transform leftHip;
    public Transform rightHip;
    //public TextMeshProUGUI saveStartPosButton;

    private List<Transform> l_startPositions = new List<Transform>();

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            l_startPositions.Clear();
            bool saved = GetStartCoords();
            if (saved) StoreStartPosition.WriteStartPosition(l_startPositions);

            print("Start Data Saved = " + saved);
        }
    }

    private bool GetStartCoords()
    {
        l_startPositions.Add(leftShoulder);
        l_startPositions.Add(rightShoulder);
        l_startPositions.Add(neck);
        l_startPositions.Add(rightHip);
        l_startPositions.Add(leftHip);

        if(l_startPositions.Count > 0) return true;

        return false;
    }

    public void setStartPosition()
    {
        l_startPositions.Clear();
        bool saved = GetStartCoords();
        if (saved) StoreStartPosition.WriteStartPosition(l_startPositions);

        print("Start Data Saved = " + saved);

    }
}
