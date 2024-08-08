using System.Collections;
using System.Collections.Generic;
using PolySpatial.Samples;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.ARFoundation;


public class ButtonManager : HubButton
{
    public UnityEvent eventOnButtonClick;

    public override void Press(){
        eventOnButtonClick.Invoke();
    }
   
}
