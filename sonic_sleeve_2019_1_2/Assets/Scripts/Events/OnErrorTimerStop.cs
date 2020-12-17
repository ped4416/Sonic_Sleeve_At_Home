using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class OnErrorTimerStop : ScriptableObject
{
    private List<OnErrorTimerStopListener> listeners = new List<OnErrorTimerStopListener>();

    public void Raise()
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnEventRaised();
        }
    }

    public void RegisterListener(OnErrorTimerStopListener listener)
    {
        listeners.Add(listener);
    }

    public void UnregisterListener(OnErrorTimerStopListener listener)
    {
        listeners.Remove(listener);
    }
}
