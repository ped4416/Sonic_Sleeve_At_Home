using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class On10SecTimerEnd : ScriptableObject
{
    private List<On10SecTimerEndListener> listeners = new List<On10SecTimerEndListener>();

    public void Raise()
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnEventRaised();
        }
    }

    public void RegisterListener(On10SecTimerEndListener listener)
    {
        listeners.Add(listener);
    }

    public void UnregisterListener(On10SecTimerEndListener listener)
    {
        listeners.Remove(listener);
    }
}
