using System.Collections;
using System.Collections.Generic;
using PolySpatial.Samples;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.ARFoundation;


public class ButtonManager : HubButton
{
    public UnityEvent eventOnButtonClick;

    public UnityEvent eventOnButtonClickWithDelay;
    public AudioSource buttonClickAudio;

    public float invokeDuration = 3;

    public override void Press(){

        if(buttonClickAudio != null){
            buttonClickAudio.Play();
        }
        StartCoroutine(InvokeEventAfterDelay());

        eventOnButtonClick.Invoke();    

    }

    IEnumerator InvokeEventAfterDelay(){
        yield return new WaitForSeconds(invokeDuration);
        eventOnButtonClickWithDelay.Invoke();

        }
    }
   

