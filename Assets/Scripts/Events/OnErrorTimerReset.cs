using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class OnErrorTimerReset : ScriptableObject
{
    private List<OnErrorTimerResetListener> listeners = new List<OnErrorTimerResetListener>();

    public void Raise()
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnEventRaised();
        }
    }

    public void RegisterListener(OnErrorTimerResetListener listener)
    {
        listeners.Add(listener);
    }

    public void UnregisterListener(OnErrorTimerResetListener listener)
    {
        listeners.Remove(listener);
    }
}
