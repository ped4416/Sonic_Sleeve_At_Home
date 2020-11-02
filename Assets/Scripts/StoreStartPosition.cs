using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using UnityEngine;

public static class StoreStartPosition
{
    public static List<Vector3> l_savedStartPositions = new List<Vector3>();
    public static List<Vector3> l_loadedStartPositions = new List<Vector3>();

    public static void WriteStartPosition(List<Vector3> positionList)
    {
        l_savedStartPositions = positionList;
        PlayerPrefs.SetFloat("LeftShoulderX", l_savedStartPositions[0].x);
        PlayerPrefs.SetFloat("LeftShoulderY", l_savedStartPositions[0].y);
        PlayerPrefs.SetFloat("LeftShoulderZ", l_savedStartPositions[0].z);
        PlayerPrefs.SetFloat("RightShoulderX", l_savedStartPositions[1].x);
        PlayerPrefs.SetFloat("RightShoulderY", l_savedStartPositions[1].y);
        PlayerPrefs.SetFloat("RightShoulderZ", l_savedStartPositions[1].z);
        PlayerPrefs.SetFloat("NeckX", l_savedStartPositions[2].x);
        PlayerPrefs.SetFloat("NeckY", l_savedStartPositions[2].y);
        PlayerPrefs.SetFloat("NeckZ", l_savedStartPositions[2].z);
        PlayerPrefs.SetFloat("RightHipX", l_savedStartPositions[3].x);
        PlayerPrefs.SetFloat("RightHipY", l_savedStartPositions[3].y);
        PlayerPrefs.SetFloat("RightHipZ", l_savedStartPositions[3].z);
        PlayerPrefs.SetFloat("LeftHipX", l_savedStartPositions[4].x);
        PlayerPrefs.SetFloat("LeftHipY", l_savedStartPositions[4].y);
        PlayerPrefs.SetFloat("LeftHipZ", l_savedStartPositions[4].z);
    }

    public static bool LoadStartPosition()
    {
        Vector3 leftShoulder = new Vector3();

        leftShoulder.x = PlayerPrefs.GetFloat("LeftShoulderX");
        leftShoulder.y = PlayerPrefs.GetFloat("LeftShoulderY");
        leftShoulder.z = PlayerPrefs.GetFloat("LeftShoulderZ");

        l_loadedStartPositions.Add(leftShoulder);

        Vector3 rightShoulder = new Vector3();

        rightShoulder.x = PlayerPrefs.GetFloat("RightShoulderX");
        rightShoulder.y = PlayerPrefs.GetFloat("RightShoulderY");
        rightShoulder.z = PlayerPrefs.GetFloat("RightShoulderZ");

        l_loadedStartPositions.Add(rightShoulder);

        Vector3 neck = new Vector3();

        neck.x = PlayerPrefs.GetFloat("NeckX");
        neck.y = PlayerPrefs.GetFloat("NeckY");
        neck.z = PlayerPrefs.GetFloat("NeckZ");

        l_loadedStartPositions.Add(neck);

        Vector3 rightHip = new Vector3();

        rightHip.x = PlayerPrefs.GetFloat("RightHipX");
        rightHip.y = PlayerPrefs.GetFloat("RightHipY");
        rightHip.z = PlayerPrefs.GetFloat("RightHipZ");

        l_loadedStartPositions.Add(rightHip);

        Vector3 leftHip = new Vector3();

        leftHip.x = PlayerPrefs.GetFloat("LeftHipX");
        leftHip.y = PlayerPrefs.GetFloat("LeftHipY");
        leftHip.z = PlayerPrefs.GetFloat("LeftHipZ");

        l_loadedStartPositions.Add(leftHip);

        if (l_loadedStartPositions.Count > 0) return true;

        return false;

    }
}
