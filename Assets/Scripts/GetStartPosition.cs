using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetStartPosition : MonoBehaviour
{

    public Transform rightShoulder;
    public Transform leftShoulder;
    public Transform neck;
    public Transform leftHip;
    public Transform rightHip;

    private List<Vector3> l_startPositions = new List<Vector3>();

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            bool saved = GetStartCoords();
            if (saved) StoreStartPosition.WriteStartPosition(l_startPositions);

            print("Start Coords Saved = " + saved);
            foreach(Vector3 pos in StoreStartPosition.l_savedStartPositions)
            {
                print("Saved pos X:" + pos.x);
                print("Saved pos Y:" + pos.y);
                print("Saved pos Z:" + pos.z);
            }
        }
    }

    private bool GetStartCoords()
    {
        l_startPositions.Add(leftShoulder.position);
        l_startPositions.Add(rightShoulder.position);
        l_startPositions.Add(neck.position);
        l_startPositions.Add(rightHip.position);
        l_startPositions.Add(leftHip.position);

        if(l_startPositions.Count > 0) return true;

        return false;
    }
}
