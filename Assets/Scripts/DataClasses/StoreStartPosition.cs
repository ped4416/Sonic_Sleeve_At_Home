using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using UnityEngine;

public static class StoreStartPosition
{
    public static List<Transform> l_savedStartPositions = new List<Transform>();
    public static List<Vector3> l_loadedStartPositions = new List<Vector3>();
    public static List<Vector4> l_loadedStartRotations = new List<Vector4>();

    public static void WriteStartPosition(List<Transform> positionList)
    {
        l_savedStartPositions = positionList;
        PlayerPrefs.SetFloat("LeftShoulderX", l_savedStartPositions[0].position.x);
        PlayerPrefs.SetFloat("LeftShoulderY", l_savedStartPositions[0].position.y);
        PlayerPrefs.SetFloat("LeftShoulderZ", l_savedStartPositions[0].position.z);
        PlayerPrefs.SetFloat("LeftShoulderRotX", l_savedStartPositions[0].rotation.x);
        PlayerPrefs.SetFloat("LeftShoulderRotY", l_savedStartPositions[0].rotation.y);
        PlayerPrefs.SetFloat("LeftShoulderRotZ", l_savedStartPositions[0].rotation.z);
        PlayerPrefs.SetFloat("LeftShoulderRotW", l_savedStartPositions[0].rotation.w);

        PlayerPrefs.SetFloat("RightShoulderX", l_savedStartPositions[1].position.x);
        PlayerPrefs.SetFloat("RightShoulderY", l_savedStartPositions[1].position.y);
        PlayerPrefs.SetFloat("RightShoulderZ", l_savedStartPositions[1].position.z);
        PlayerPrefs.SetFloat("RighttShoulderRotX", l_savedStartPositions[1].rotation.x);
        PlayerPrefs.SetFloat("RightShoulderRotY", l_savedStartPositions[1].rotation.y);
        PlayerPrefs.SetFloat("RightShoulderRotZ", l_savedStartPositions[1].rotation.z);
        PlayerPrefs.SetFloat("RightShoulderRotW", l_savedStartPositions[1].rotation.w);

        PlayerPrefs.SetFloat("NeckX", l_savedStartPositions[2].position.x);
        PlayerPrefs.SetFloat("NeckY", l_savedStartPositions[2].position.y);
        PlayerPrefs.SetFloat("NeckZ", l_savedStartPositions[2].position.z);
        PlayerPrefs.SetFloat("NeckRotX", l_savedStartPositions[2].rotation.x);
        PlayerPrefs.SetFloat("NeckRotY", l_savedStartPositions[2].rotation.y);
        PlayerPrefs.SetFloat("NeckRotZ", l_savedStartPositions[2].rotation.z);
        PlayerPrefs.SetFloat("NeckRotW", l_savedStartPositions[2].rotation.w);

        PlayerPrefs.SetFloat("RightHipX", l_savedStartPositions[3].position.x);
        PlayerPrefs.SetFloat("RightHipY", l_savedStartPositions[3].position.y);
        PlayerPrefs.SetFloat("RightHipZ", l_savedStartPositions[3].position.z);
        PlayerPrefs.SetFloat("RightHipRotX", l_savedStartPositions[3].rotation.x);
        PlayerPrefs.SetFloat("RightHipRotY", l_savedStartPositions[3].rotation.y);
        PlayerPrefs.SetFloat("RightHipRotZ", l_savedStartPositions[3].rotation.z);
        PlayerPrefs.SetFloat("RightHipRotW", l_savedStartPositions[3].rotation.w);

        PlayerPrefs.SetFloat("LeftHipX", l_savedStartPositions[4].position.x);
        PlayerPrefs.SetFloat("LeftHipY", l_savedStartPositions[4].position.y);
        PlayerPrefs.SetFloat("LeftHipZ", l_savedStartPositions[4].position.z);
        PlayerPrefs.SetFloat("LeftHipRotX", l_savedStartPositions[4].rotation.x);
        PlayerPrefs.SetFloat("LeftHipRotY", l_savedStartPositions[4].rotation.y);
        PlayerPrefs.SetFloat("LeftHipRotZ", l_savedStartPositions[4].rotation.z);
        PlayerPrefs.SetFloat("LeftHipRotW", l_savedStartPositions[4].rotation.w);
    }

    public static bool LoadStartPosition()
    {
        Vector3 leftShoulderPos = new Vector3();

        leftShoulderPos.x = PlayerPrefs.GetFloat("LeftShoulderX");
        leftShoulderPos.y = PlayerPrefs.GetFloat("LeftShoulderY");
        leftShoulderPos.z = PlayerPrefs.GetFloat("LeftShoulderZ");

        l_loadedStartPositions.Add(leftShoulderPos);

        Vector4 leftShoulderRot = new Vector4();

        leftShoulderRot.x = PlayerPrefs.GetFloat("LeftShoulderRotX");
        leftShoulderRot.y = PlayerPrefs.GetFloat("LeftShoulderRotY");
        leftShoulderRot.z = PlayerPrefs.GetFloat("LeftShoulderRotZ");
        leftShoulderRot.w = PlayerPrefs.GetFloat("LeftShoulderRotW");

        l_loadedStartRotations.Add(leftShoulderRot);

        Vector3 rightShoulderPos = new Vector3();

        rightShoulderPos.x = PlayerPrefs.GetFloat("RightShoulderX");
        rightShoulderPos.y = PlayerPrefs.GetFloat("RightShoulderY");
        rightShoulderPos.z = PlayerPrefs.GetFloat("RightShoulderZ");

        l_loadedStartPositions.Add(rightShoulderPos);

        Vector4 rightShoulderRot = new Vector4();

        rightShoulderRot.x = PlayerPrefs.GetFloat("RightShoulderRotX");
        rightShoulderRot.y = PlayerPrefs.GetFloat("RightShoulderRotY");
        rightShoulderRot.z = PlayerPrefs.GetFloat("RightShoulderRotZ");
        rightShoulderRot.w = PlayerPrefs.GetFloat("RightShoulderRotW");

        l_loadedStartRotations.Add(rightShoulderRot);

        Vector3 neckPos = new Vector3();

        neckPos.x = PlayerPrefs.GetFloat("NeckX");
        neckPos.y = PlayerPrefs.GetFloat("NeckY");
        neckPos.z = PlayerPrefs.GetFloat("NeckZ");

        l_loadedStartPositions.Add(neckPos);

        Vector4 neckRot = new Vector4();

        neckRot.x = PlayerPrefs.GetFloat("NeckRotX");
        neckRot.y = PlayerPrefs.GetFloat("NeckRotY");
        neckRot.z = PlayerPrefs.GetFloat("NeckRotZ");
        neckRot.w = PlayerPrefs.GetFloat("NeckRotW");

        l_loadedStartRotations.Add(neckRot);

        Vector3 rightHipPos = new Vector3();

        rightHipPos.x = PlayerPrefs.GetFloat("RightHipX");
        rightHipPos.y = PlayerPrefs.GetFloat("RightHipY");
        rightHipPos.z = PlayerPrefs.GetFloat("RightHipZ");

        l_loadedStartPositions.Add(rightHipPos);

        Vector4 rightHipRot = new Vector4();

        rightHipRot.x = PlayerPrefs.GetFloat("RightHipRotX");
        rightHipRot.y = PlayerPrefs.GetFloat("RightHipRotY");
        rightHipRot.z = PlayerPrefs.GetFloat("RightHipRotZ");
        rightHipRot.w = PlayerPrefs.GetFloat("RightHipRotW");

        l_loadedStartRotations.Add(rightHipRot);

        Vector3 leftHipPos = new Vector3();

        leftHipPos.x = PlayerPrefs.GetFloat("LeftHipX");
        leftHipPos.y = PlayerPrefs.GetFloat("LeftHipY");
        leftHipPos.z = PlayerPrefs.GetFloat("LeftHipZ");

        l_loadedStartPositions.Add(leftHipPos);

        Vector4 leftHipRot = new Vector4();

        leftHipRot.x = PlayerPrefs.GetFloat("LeftHipRotX");
        leftHipRot.y = PlayerPrefs.GetFloat("LeftHipRotY");
        leftHipRot.z = PlayerPrefs.GetFloat("LeftHipRotZ");
        leftHipRot.w = PlayerPrefs.GetFloat("LeftHipRotW");

        l_loadedStartRotations.Add(leftHipRot);

        if (l_loadedStartPositions.Count > 0 && l_loadedStartRotations.Count > 0) return true;

        return false;

    }
}
