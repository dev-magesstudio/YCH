using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneAnim : MonoBehaviour
{
    public GameObject logo;
    public AudioSource backgroundAudio;
    
    public void PlayNextAnim()
    {
        logo.GetComponent<Animator>().enabled = true;
        this.gameObject.SetActive(false);
        backgroundAudio.Play();
    }
}
