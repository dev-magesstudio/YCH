using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting;


public class AudioManager : MonoBehaviour
{
    AudioSource audioSource;

    public void IncreaseVolume(){
        audioSource.volume = 0.8f;
    }

    public void DecreaseVolume(){
        audioSource.volume = 0.2f;

    }

    public void PlaySound(){
        //audioSource.volume = 0.8f;
        audioSource.Play();
    }

    public void StopSound(){
        audioSource.Stop();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject go = GameObject.FindGameObjectWithTag("BackgroundSound");
        audioSource = go.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
