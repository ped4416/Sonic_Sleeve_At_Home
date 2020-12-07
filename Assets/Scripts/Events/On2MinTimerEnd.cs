using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class On2MinTimerEnd : ScriptableObject
{
    private List<On2MinTimerEndListener> listeners = new List<On2MinTimerEndListener>();

    public void Raise()
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnEventRaised();
        }
    }

    public void RegisterListener(On2MinTimerEndListener listener)
    {
        listeners.Add(listener);
    }

    public void UnregisterListener(On2MinTimerEndListener listener)
    {
        listeners.Remove(listener);
    }
}
