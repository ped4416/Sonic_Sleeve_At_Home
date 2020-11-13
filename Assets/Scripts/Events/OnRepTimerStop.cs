using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class OnRepTimerStop : ScriptableObject
{
    private List<OnRepTimerStopListener> listeners = new List<OnRepTimerStopListener>();

    public void Raise()
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnEventRaised();
        }
    }

    public void RegisterListener(OnRepTimerStopListener listener)
    {
        listeners.Add(listener);
    }

    public void UnregisterListener(OnRepTimerStopListener listener)
    {
        listeners.Remove(listener);
    }
}
