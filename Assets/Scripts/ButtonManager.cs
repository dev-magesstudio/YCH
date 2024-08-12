using System.Collections;
using System.Collections.Generic;
using PolySpatial.Samples;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.ARFoundation;


public class ButtonManager : HubButton
{
    public UnityEvent eventOnButtonClick;
    public AudioSource buttonClickAudio;

    public override void Press(){

        if(buttonClickAudio != null){
            buttonClickAudio.Play();
        }

        StartCoroutine(InvokeEvent());

    }

    IEnumerator InvokeEvent(){
        yield return new WaitForSeconds(buttonClickAudio.clip.length);
        eventOnButtonClick.Invoke();

        }
    }
   

