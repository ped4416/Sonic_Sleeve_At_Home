using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class OnBelowThresh : ScriptableObject
{
    private List<OnBelowThreshListener> listeners = new List<OnBelowThreshListener>();

    public void Raise()
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnEventRaised();
        }
    }

    public void RegisterListener(OnBelowThreshListener listener)
    {
        listeners.Add(listener);
    }

    public void UnregisterListener(OnBelowThreshListener listener)
    {
        listeners.Remove(listener);
    }
}
