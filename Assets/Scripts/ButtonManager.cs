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

    public float invokeDuration = 5;


    public GameObject seq1;
    public Animator drone;
    public string parameterName = "buttonClicked";

    public GameObject logo;
    public float targetScaleMultiplier = 3f;
    public float scaleDuration = 2f;

    public string exitStateName;
    private bool isStateExited = false;

    public override void Press(){

        if(buttonClickAudio != null){
            buttonClickAudio.Play();
        }
        StartCoroutine(InvokeEventAfterDelay());

        eventOnButtonClick.Invoke();

        drone.SetBool(parameterName, true);
       
        




    }


    IEnumerator InvokeEventAfterDelay(){
        yield return new WaitForSeconds(invokeDuration);
        eventOnButtonClickWithDelay.Invoke();

        }

  


}
   

