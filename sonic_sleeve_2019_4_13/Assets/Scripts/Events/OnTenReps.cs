using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class broadcasts an event notification when the rep counter
/// reaches 10 reps.
/// </summary>

[CreateAssetMenu]
public class OnTenReps : ScriptableObject
{
    private List<OnTenRepsListener> listeners = new List<OnTenRepsListener>();

    public void Raise()
    {
        for(int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnEventRaised();
        }
    }

    public void RegisterListener(OnTenRepsListener listener)
    {
        listeners.Add(listener);
    }

    public void UnregisterListener(OnTenRepsListener listener)
    {
        listeners.Remove(listener);
    }
}
