using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class OnRepTimerReset : ScriptableObject
{
    private List<OnRepTimerResetListener> listeners = new List<OnRepTimerResetListener>();

    public void Raise()
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnEventRaised();
        }
    }

    public void RegisterListener(OnRepTimerResetListener listener)
    {
        listeners.Add(listener);
    }

    public void UnregisterListener(OnRepTimerResetListener listener)
    {
        listeners.Remove(listener);
    }
}
