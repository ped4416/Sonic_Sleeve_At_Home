using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class OnStartMusic : ScriptableObject
{
    private List<OnStartMusicListener> listeners = new List<OnStartMusicListener>();

    public void Raise()
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnEventRaised();
        }
    }

    public void RegisterListener(OnStartMusicListener listener)
    {
        listeners.Add(listener);
    }

    public void UnregisterListener(OnStartMusicListener listener)
    {
        listeners.Remove(listener);
    }
}
