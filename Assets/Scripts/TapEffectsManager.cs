using Unity.PolySpatial.InputDevices;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.InputSystem.LowLevel;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using UnityEngine.Events;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;
using PolySpatial.Samples;


public class TapEffectsManager : MonoBehaviour
{
    public UnityEvent eventOnButtonClick;
    public UnityEvent eventOnButtonRelease;
    public AudioSource buttonClickAudio;

    // private bool isPressed = false;
    //  public override void Press()
    // {
    //     if (buttonClickAudio != null)
    //     {
    //         buttonClickAudio.Play();
    //     }

    //     if (eventOnButtonClick != null)
    //     {
    //         eventOnButtonClick.Invoke();
    //     }

    //     isPressed = true;
    // }

    void OnEnable()
    {
        EnhancedTouchSupport.Enable();
    }

    void Update()
    {
        // if(isPressed){
        //     var activeTouches = Touch.activeTouches;

        // if (activeTouches.Count > 0)
        // {
        //     SpatialPointerState primaryTouchData = EnhancedSpatialPointerSupport.GetPointerState(activeTouches[0]);

        //      if (primaryTouchData.Kind == SpatialPointerKind.Touch)
        //       { 
        //         if(activeTouches[0].phase == TouchPhase.Moved || activeTouches[0].phase == TouchPhase.Stationary){
        //             eventOnButtonClick.Invoke();
        //         }
        //         else if(activeTouches[0].phase == TouchPhase.Ended){
        //             if (eventOnButtonRelease != null)
        //         {
        //             eventOnButtonRelease.Invoke();
        //         }
        //         isPressed = false;

        //         }
        //      }
        // }
        // }

        foreach (var touch in Touch.activeTouches)
        {
            var spatialPointerState = EnhancedSpatialPointerSupport.GetPointerState(touch);

            //Ignore indirect or direct pinch states
            if (spatialPointerState.Kind == SpatialPointerKind.DirectPinch || spatialPointerState.Kind == SpatialPointerKind.IndirectPinch)
                continue;

            switch (spatialPointerState.phase)
            {
                case SpatialPointerPhase.Began:
                case SpatialPointerPhase.Moved:
                    eventOnButtonClick.Invoke();
                    break;

                case SpatialPointerPhase.Ended:
                case SpatialPointerPhase.Cancelled:
                    eventOnButtonRelease.Invoke();
                    break;
            }


        }


    }

}
