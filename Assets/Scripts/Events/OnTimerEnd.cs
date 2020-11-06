using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class OnTimerEnd : ScriptableObject
{
    private List<OnTimerEndListener> listeners = new List<OnTimerEndListener>();

    public void Raise()
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnEventRaised();
        }
    }

    public void RegisterListener(OnTimerEndListener listener)
    {
        listeners.Add(listener);
    }

    public void UnregisterListener(OnTimerEndListener listener)
    {
        listeners.Remove(listener);
    }
}
