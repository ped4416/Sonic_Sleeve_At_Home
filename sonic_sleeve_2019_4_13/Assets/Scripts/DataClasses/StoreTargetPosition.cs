using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using UnityEngine;

public static class StoreTargetPosition
{
    public static List<Vector3> l_savedTargetPosition = new List<Vector3>();
    public static List<Vector3> l_loadedTargetPosition = new List<Vector3>();

    public static void WriteTargetPosition(List<Vector3> positionList)
    {
        l_savedTargetPosition = positionList;
        PlayerPrefs.SetFloat("HandX", l_savedTargetPosition[0].x);
        PlayerPrefs.SetFloat("HandY", l_savedTargetPosition[0].y);
        PlayerPrefs.SetFloat("HandZ", l_savedTargetPosition[0].z);
        PlayerPrefs.SetFloat("WristX", l_savedTargetPosition[1].x);
        PlayerPrefs.SetFloat("WristY", l_savedTargetPosition[1].y);
        PlayerPrefs.SetFloat("WristZ", l_savedTargetPosition[1].z);
    }

    public static bool LoadTargetPosition()
    {
        Vector3 hand = new Vector3();

        hand.x = PlayerPrefs.GetFloat("HandX");
        hand.y = PlayerPrefs.GetFloat("HandY");
        hand.z = PlayerPrefs.GetFloat("HandZ");

        l_loadedTargetPosition.Add(hand);

        Vector3 wrist = new Vector3();

        wrist.x = PlayerPrefs.GetFloat("WristX");
        wrist.y = PlayerPrefs.GetFloat("WristY");
        wrist.z = PlayerPrefs.GetFloat("WristZ");

        l_loadedTargetPosition.Add(wrist);

        if (l_loadedTargetPosition.Count > 0) return true;

        return false;
    }
}
