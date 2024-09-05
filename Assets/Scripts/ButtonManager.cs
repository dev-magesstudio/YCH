using Unity.PolySpatial.InputDevices;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.InputSystem.LowLevel;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using UnityEngine.Events;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;
using PolySpatial.Samples;
using System.Collections;



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

//#if(UNITY_EDITOR)
    // public override void Press(){

    //     if(buttonClickAudio != null){
    //         buttonClickAudio.Play();
    //     }
    //     if(eventOnButtonClickWithDelay!=null){
    //         StartCoroutine(InvokeEventAfterDelay());
    //     }

    //     if(eventOnButtonClick!=null){
    //        eventOnButtonClick.Invoke();
    //     }

    //     if(drone!=null){
    //        drone.SetBool(parameterName, true);
    //     }
    // }
   // #endif


    IEnumerator InvokeEventAfterDelay(){
        yield return new WaitForSeconds(invokeDuration);
        eventOnButtonClickWithDelay.Invoke();

        }

    
    public void QuitApplication(){
        Application.Quit();
    }

     void OnEnable()
    {
        EnhancedTouchSupport.Enable();
    }

    void Update(){
         foreach(var touch in Touch.activeTouches){
            var spatialPointerState = EnhancedSpatialPointerSupport.GetPointerState(touch);

            //Ignore indirect or direct pinch states
            if (spatialPointerState.Kind == SpatialPointerKind.DirectPinch || spatialPointerState.Kind == SpatialPointerKind.IndirectPinch)
                    continue;

             switch (spatialPointerState.phase){

                case SpatialPointerPhase.Began:
                  if(buttonClickAudio != null){
                        buttonClickAudio.Play();
                     }
                if(eventOnButtonClickWithDelay!=null){
                StartCoroutine(InvokeEventAfterDelay());
                }

                if(eventOnButtonClick!=null){
                eventOnButtonClick.Invoke();
                }

                if(drone!=null){
                drone.SetBool(parameterName, true);
                }
                break;

                //  case SpatialPointerPhase.Ended:
                // // eventOnButtonRelease.Invoke();
                // break;
             }

            
        }
    }


}
   

