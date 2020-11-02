using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CompareStartPosition : MonoBehaviour
{
    public Transform rightShoulder;
    public Transform leftShoulder;
    public Transform neck;
    public Transform leftHip;
    public Transform rightHip;
    public float errorMargin;

    private List<Vector3> l_realTimePosition = new List<Vector3>();
    private List<Vector3> l_referencePosition = new List<Vector3>();
    private bool b_referencePosLoaded;

    // Start is called before the first frame update
    void Start()
    {
        b_referencePosLoaded = StoreStartPosition.LoadStartPosition();           
    }

    // Update is called once per frame
    void Update()
    {
        if (b_referencePosLoaded && Input.GetKeyDown("c"))
        {
            bool matched = ComparePositions();
            if(matched)
            {
                print("Correct Position!");
            } else
            {
                print("Wrong Position!");
            }
            
        }
    }
    private bool ComparePositions()
    {
        Vector3 currentLeftShoulder = new Vector3();
        Vector3 referenceLeftShoulder = new Vector3();
        Vector3 currentRightShoulder = new Vector3();
        Vector3 referenceRightShoulder = new Vector3();
        Vector3 currentNeck = new Vector3();
        Vector3 referenceNeck = new Vector3();
        Vector3 currentRightHip = new Vector3();
        Vector3 referenceRightHip = new Vector3();
        Vector3 currentLeftHip = new Vector3();
        Vector3 referenceLeftHip = new Vector3();

        currentLeftShoulder = leftShoulder.position;
        referenceLeftShoulder.Set(StoreStartPosition.l_loadedStartPositions[0].x, StoreStartPosition.l_loadedStartPositions[0].y, StoreStartPosition.l_loadedStartPositions[0].z);

        currentRightShoulder = rightShoulder.position;
        referenceRightShoulder.Set(StoreStartPosition.l_loadedStartPositions[1].x, StoreStartPosition.l_loadedStartPositions[1].y, StoreStartPosition.l_loadedStartPositions[1].z);

        currentNeck = neck.position;
        referenceNeck.Set(StoreStartPosition.l_loadedStartPositions[2].x, StoreStartPosition.l_loadedStartPositions[2].y, StoreStartPosition.l_loadedStartPositions[2].z);

        currentRightHip = rightHip.position;
        referenceRightHip.Set(StoreStartPosition.l_loadedStartPositions[3].x, StoreStartPosition.l_loadedStartPositions[3].y, StoreStartPosition.l_loadedStartPositions[3].z);

        currentLeftHip = leftHip.position;
        referenceLeftHip.Set(StoreStartPosition.l_loadedStartPositions[4].x, StoreStartPosition.l_loadedStartPositions[4].y, StoreStartPosition.l_loadedStartPositions[4].z);

        float f_distLShoulder = Vector3.Distance(currentLeftShoulder, referenceLeftShoulder);
        float f_distRShoulder = Vector3.Distance(currentRightShoulder, referenceRightShoulder);
        float f_distNeck = Vector3.Distance(currentNeck, referenceNeck);
        float f_distRHip = Vector3.Distance(currentRightHip, referenceRightHip);
        float f_distLHip = Vector3.Distance(currentLeftHip, referenceLeftHip);
        float f_totalDist = f_distLShoulder + f_distRShoulder + f_distNeck + f_distRHip + f_distLHip;
        if (f_totalDist < errorMargin) return true;

        return false;
    }
}
