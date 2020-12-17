using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class OnRestStart : ScriptableObject
{
    private List<OnRestStartListener> listeners = new List<OnRestStartListener>();

    public void Raise()
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnEventRaised();
        }
    }

    public void RegisterListener(OnRestStartListener listener)
    {
        listeners.Add(listener);
    }

    public void UnregisterListener(OnRestStartListener listener)
    {
        listeners.Remove(listener);
    }
}
