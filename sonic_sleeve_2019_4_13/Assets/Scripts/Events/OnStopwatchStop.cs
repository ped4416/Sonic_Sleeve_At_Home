using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class OnStopwatchStop : ScriptableObject
{
    private List<OnStopwatchStopListener> listeners = new List<OnStopwatchStopListener>();

    public void Raise()
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnEventRaised();
        }
    }

    public void RegisterListener(OnStopwatchStopListener listener)
    {
        listeners.Add(listener);
    }

    public void UnregisterListener(OnStopwatchStopListener listener)
    {
        listeners.Remove(listener);
    }
}
