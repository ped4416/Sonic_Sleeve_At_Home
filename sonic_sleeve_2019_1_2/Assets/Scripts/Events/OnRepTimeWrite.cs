using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class OnRepTimeWrite : ScriptableObject
{
    private List<OnRepTimeWriteListener> listeners = new List<OnRepTimeWriteListener>();

    public void Raise()
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnEventRaised();
        }
    }

    public void RegisterListener(OnRepTimeWriteListener listener)
    {
        listeners.Add(listener);
    }

    public void UnregisterListener(OnRepTimeWriteListener listener)
    {
        listeners.Remove(listener);
    }
}
