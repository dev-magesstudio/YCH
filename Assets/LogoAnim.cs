using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoAnim : MonoBehaviour
{
    public TextFadeOut logoAnimController;
    public Animator logoAnimator;

    public GameObject quitBtn;


    
    // Start is called before the first frame update
    void Start()
    {
        logoAnimator = GetComponent<Animator>();
    }

    void OnAnimationComplete(){
        logoAnimController.StartFadeOut();
    }

    void OnAnimationCompleteForQuitBtn(){
        if(quitBtn!= null){
            quitBtn.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
