using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordTargetPosition : MonoBehaviour
{
    public Transform rightWrist;
    public Transform leftWrist;
    public Transform rightHand;
    public Transform leftHand;

    private List<Vector3> l_targetPositions = new List<Vector3>();
    private bool hand;

    // Start is called before the first frame update
    void Start()
    {
        hand = true; //left hand = false, right hand = true
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            bool captured = GetTargetCoords();
            if (captured)
            {
                StoreTargetPosition.WriteTargetPosition(l_targetPositions);
                print("Target Coords Captured =" + captured);
                print("Hand Position: " + l_targetPositions[0].x + "    ||  " + l_targetPositions[0].y + "    ||  " + l_targetPositions[0].z);
                print("Wrist Position: " + l_targetPositions[1].x + "   ||  " + l_targetPositions[1].y + "  ||  " + l_targetPositions[1].z);
            }
        }
    }

    private bool GetTargetCoords()
    {
        l_targetPositions.Clear();

        if(hand)
        {
            l_targetPositions.Add(rightHand.position);
            l_targetPositions.Add(rightWrist.position);

            if(l_targetPositions.Count > 0) return true;
        } else
        {
            l_targetPositions.Add(leftHand.position);
            l_targetPositions.Add(leftWrist.position);

            if(l_targetPositions.Count > 0) return true;
        }

        return false;
    }
}
