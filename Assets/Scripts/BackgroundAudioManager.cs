using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundAudioManager : MonoBehaviour
{
    void Awake(){
        DontDestroyOnLoad(this.gameObject);
    }
 
}
