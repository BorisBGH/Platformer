using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;

public class EventsArray : MonoBehaviour
{
    public UnityEvent[] Events;

    public void StartEvent(int index)
    {
        Events[index].Invoke();
    }
}
