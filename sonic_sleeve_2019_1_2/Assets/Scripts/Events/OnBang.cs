using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class OnBang : ScriptableObject
{
    private List<OnBangListener> listeners = new List<OnBangListener>();

    public void Raise()
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnEventRaised();
        }
    }

    public void RegisterListener(OnBangListener listener)
    {
        listeners.Add(listener);
    }

    public void UnregisterListener(OnBangListener listener)
    {
        listeners.Remove(listener);
    }
}
