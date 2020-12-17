using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// This class listens to the OnTenReps scriptable object and 
/// activates an attached method when the event is raised.
/// </summary>
public class OnTenRepsListener : MonoBehaviour
{
    public OnTenReps Event;
    public UnityEvent Response;

    private void OnEnable()
    { 
        Event.RegisterListener(this); 
    }

    private void OnDisable()
    { 
        Event.UnregisterListener(this); 
    }

    public void OnEventRaised()
    { 
        Response.Invoke(); 
    }
}
