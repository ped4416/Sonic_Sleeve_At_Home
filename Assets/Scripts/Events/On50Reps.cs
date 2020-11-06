using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class On50Reps : ScriptableObject
{
    private List<On50RepsListener> listeners = new List<On50RepsListener>();

    public void Raise()
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnEventRaised();
        }
    }

    public void RegisterListener(On50RepsListener listener)
    {
        listeners.Add(listener);
    }

    public void UnregisterListener(On50RepsListener listener)
    {
        listeners.Remove(listener);
    }
}
