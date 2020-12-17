using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class OnAboveThresh : ScriptableObject
{
    private List<OnAboveThreshListener> listeners = new List<OnAboveThreshListener>();

    public void Raise()
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnEventRaised();
        }
    }

    public void RegisterListener(OnAboveThreshListener listener)
    {
        listeners.Add(listener);
    }

    public void UnregisterListener(OnAboveThreshListener listener)
    {
        listeners.Remove(listener);
    }
}
