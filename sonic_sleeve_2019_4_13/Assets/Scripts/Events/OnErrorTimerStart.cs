using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class OnErrorTimerStart : ScriptableObject
{
    private List<OnErrorTimerStartListener> listeners = new List<OnErrorTimerStartListener>();

    public void Raise()
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnEventRaised();
        }
    }

    public void RegisterListener(OnErrorTimerStartListener listener)
    {
        listeners.Add(listener);
    }

    public void UnregisterListener(OnErrorTimerStartListener listener)
    {
        listeners.Remove(listener);
    }
}
