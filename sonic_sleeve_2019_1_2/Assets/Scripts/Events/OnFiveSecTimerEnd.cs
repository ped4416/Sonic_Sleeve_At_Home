using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class OnFiveSecTimerEnd : ScriptableObject
{
    private List<OnFiveSecTimerEndListener> listeners = new List<OnFiveSecTimerEndListener>();

    public void Raise()
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnEventRaised();
        }
    }

    public void RegisterListener(OnFiveSecTimerEndListener listener)
    {
        listeners.Add(listener);
    }

    public void UnregisterListener(OnFiveSecTimerEndListener listener)
    {
        listeners.Remove(listener);
    }
}
