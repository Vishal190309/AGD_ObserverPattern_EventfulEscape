using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventController 
{
    public event Action baseEvent;

    public void AddListner(Action listner) => baseEvent += listner;
    public void RemoveListner(Action listner) => baseEvent -= listner;
    public void Invoke() => baseEvent?.Invoke();
}
