using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LogoAnim : MonoBehaviour
{
    public TextFadeOut logoAnimController;
    public Animator logoAnimator;

    // public GameObject quitBtn;

    public UnityEvent eventOnCompletion;



    // Start is called before the first frame update
    void Start()
    {
        logoAnimator = GetComponent<Animator>();
    }

    void OnAnimationComplete()
    {
        logoAnimController.StartFadeOut();
    }

    void OnAnimationCompleteForQuitBtn()
    {
        if (eventOnCompletion != null)
        {
            eventOnCompletion.Invoke();
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
