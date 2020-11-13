using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class OnStopwatchReset : ScriptableObject
{
    private List<OnStopwatchResetListener> listeners = new List<OnStopwatchResetListener>();

    public void Raise()
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnEventRaised();
        }
    }

    public void RegisterListener(OnStopwatchResetListener listener)
    {
        listeners.Add(listener);
    }

    public void UnregisterListener(OnStopwatchResetListener listener)
    {
        listeners.Remove(listener);
    }
}
