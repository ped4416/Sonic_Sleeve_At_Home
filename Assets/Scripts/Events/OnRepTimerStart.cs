using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class OnRepTimerStart : ScriptableObject
{
    private List<OnRepTimerStartListener> listeners = new List<OnRepTimerStartListener>();

    public void Raise()
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnEventRaised();
        }
    }

    public void RegisterListener(OnRepTimerStartListener listener)
    {
        listeners.Add(listener);
    }

    public void UnregisterListener(OnRepTimerStartListener listener)
    {
        listeners.Remove(listener);
    }
}
