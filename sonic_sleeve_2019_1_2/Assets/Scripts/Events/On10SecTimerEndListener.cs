using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class On10SecTimerEndListener : MonoBehaviour
{
    public On10SecTimerEnd Event;
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
