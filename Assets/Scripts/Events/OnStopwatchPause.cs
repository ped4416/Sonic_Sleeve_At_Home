using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class OnStopwatchPause : ScriptableObject
{
    private List<OnStopwatchPauseListener> listeners = new List<OnStopwatchPauseListener>();

    public void Raise()
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnEventRaised();
        }
    }

    public void RegisterListener(OnStopwatchPauseListener listener)
    {
        listeners.Add(listener);
    }

    public void UnregisterListener(OnStopwatchPauseListener listener)
    {
        listeners.Remove(listener);
    }
}
