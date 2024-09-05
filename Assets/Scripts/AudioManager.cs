using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting;


public class AudioManager : MonoBehaviour
{
    AudioSource audioSource;
    public float fadeDuration = 1.0f;

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

    public void FadeOutSound(){
       StartCoroutine(FadeOutCoroutine());

    }

    private IEnumerator FadeOutCoroutine()
    {
        float startVolume = audioSource.volume;

        // Gradually reduce the volume
        while (audioSource.volume > 0)
        {
            audioSource.volume -= startVolume * Time.deltaTime / fadeDuration;

            yield return null;  // Wait until the next frame
        }

        // Stop the audio once the fade-out is complete
        audioSource.Stop();
        audioSource.volume = startVolume;  // Reset volume to its original value
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
