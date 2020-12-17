using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class OnPositionFound : ScriptableObject
{
    private List<OnPositionFoundListener> listeners = new List<OnPositionFoundListener>();

    public void Raise()
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnEventRaised();
        }
    }

    public void RegisterListener(OnPositionFoundListener listener)
    {
        listeners.Add(listener);
    }

    public void UnregisterListener(OnPositionFoundListener listener)
    {
        listeners.Remove(listener);
    }
}
