using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class OnStopwatchStart : ScriptableObject
{
    private List<OnStopwatchStartListener> listeners = new List<OnStopwatchStartListener>();

    public void Raise()
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnEventRaised();
        }
    }

    public void RegisterListener(OnStopwatchStartListener listener)
    {
        listeners.Add(listener);
    }

    public void UnregisterListener(OnStopwatchStartListener listener)
    {
        listeners.Remove(listener);
    }
}
