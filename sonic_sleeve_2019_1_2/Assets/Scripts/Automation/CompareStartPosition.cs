using System.Collections;
using System.Collections.Generic;
using TMPro;
#if UNITY_EDITOR
    using UnityEditorInternal;
#endif
using UnityEngine;

public class CompareStartPosition : MonoBehaviour
{
    public Transform rightShoulder;
    public Transform leftShoulder;
    public Transform neck;
    public Transform leftHip;
    public Transform rightHip;
    public float f_startPosThresh;
    /*public On10SecTimerEndListener tenSecTimerEndListener;*/
    public OnPositionFound positionFound;
    public GameObject startPosThreshInput;

    private List<Vector3> l_realTimePosition = new List<Vector3>();
    private List<Vector3> l_referencePosition = new List<Vector3>();
    private bool b_referencePosLoaded;
    private bool b_singleCheck;
    private bool b_autoCheck;
    private string s_startPosThresh;

    // Start is called before the first frame update
    void Start()
    {
        b_referencePosLoaded = StoreStartPosition.LoadStartPosition();
        f_startPosThresh = PlayerPrefs.GetFloat("Start Position Threshold");
        string s_initialThreshVal = f_startPosThresh.ToString();
        startPosThreshInput.GetComponent<TMP_InputField>().text = s_initialThreshVal;
    }

    // Update is called once per frame
    void Update()
    {
        if (b_referencePosLoaded && Input.GetKeyDown(KeyCode.C))
        {
            b_singleCheck = true;
            ComparePositions();
        }

        s_startPosThresh = startPosThreshInput.GetComponent<TMP_InputField>().text;
        f_startPosThresh = float.Parse(s_startPosThresh);
    }

    public void CheckPositionAuto()
    {
        b_autoCheck = true;
        StartCoroutine(ComparePositionCoroutine());
    }

    IEnumerator ComparePositionCoroutine()
    {
        while(b_autoCheck)
        {
            print("Please wait: checking start position");
            ComparePositions();
            yield return new WaitForSeconds(2);
        }
    }

    private void ComparePositions()
    {
        if (!b_referencePosLoaded) print("NO REFERENCE POSITION STORED");
        
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



        if (f_totalDist < f_startPosThresh)
        {
            print("Correct Position");
            if (!b_singleCheck)
            {
                b_autoCheck = false;
                StopCoroutine(ComparePositionCoroutine());
                positionFound.Raise();
            }
            else
            {
                positionFound.Raise();
            }
        }
        else
        {
            print("Wrong Position: Please adjust your sitting position");
            Vector3 v_neckDiff = referenceNeck - currentNeck;
            print("Diff X: " + v_neckDiff.x + " || Diff Y: " + v_neckDiff.y + " || Diff Z: " + v_neckDiff.z);

            float f_largestComponentVal = Mathf.Max(Mathf.Abs(v_neckDiff.x), Mathf.Max(Mathf.Abs(v_neckDiff.y), Mathf.Abs(v_neckDiff.z)));
            
            if (v_neckDiff.x > 0 && Mathf.Abs(v_neckDiff.x) == f_largestComponentVal)
            {
                print("Move Left");
            }
            else if (v_neckDiff.x < 0 && Mathf.Abs(v_neckDiff.x) == f_largestComponentVal)
            {
                print("Move Right");
            }

            if(v_neckDiff.y > 0 && Mathf.Abs(v_neckDiff.y) == f_largestComponentVal)
            {
                print("Move Up");
            }
            else if(v_neckDiff.y < 0 && Mathf.Abs(v_neckDiff.y) == f_largestComponentVal)
            {
                print("Move Down");
            }

            if (v_neckDiff.z > 0 && Mathf.Abs(v_neckDiff.z) == f_largestComponentVal)
            {
                print("Move Back");
            }
            else if (v_neckDiff.z < 0 && Mathf.Abs(v_neckDiff.z) == f_largestComponentVal)
            {
                print("Move Forward");
            }
        }

        b_singleCheck = false;
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.SetFloat("Start Position Threshold", f_startPosThresh);
    }
}
