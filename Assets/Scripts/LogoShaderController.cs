using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class LogoShaderController : MonoBehaviour
{
    public Material material;
    public string thresholdProperty = "_VisibilityThreshold";
    public float startThreshold = -1.5f;
    public float endThreshold = 1.5f;
    public float duration = 5f;

    public UnityEvent eventOnCompletion;
    public AudioSource audioSource;
    

private Coroutine thresholdCoroutine;

    // Start is called before the first frame update
    void Start()
    {
        if(material.HasProperty(thresholdProperty)){
            thresholdCoroutine = StartCoroutine(ChangeThresholdOverTime(startThreshold, endThreshold, duration));
            Invoke("PlayAudio",2); //Little hardcoded to wait for the model to load first //Can work on it later to get a proper workaround
        }
        else{
            Debug.Log("No such property in material found!");
        }
    }

    public void PlayAudio(){
                if(audioSource != null){
                audioSource.Play();
            }
    }

    IEnumerator ChangeThresholdOverTime(float startValue, float endValue, float duration)
    {
        
        float elapsedTime = 0f;
        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            
            
            float newThreshold = Mathf.Lerp(startValue, endValue, elapsedTime / duration);

            // Set the threshold property on the material
            material.SetFloat(thresholdProperty, newThreshold);

            yield return null; // Wait for the next frame
            
            
        }

        

        // Ensure the final value is set
        material.SetFloat(thresholdProperty, endValue);

        if(eventOnCompletion!=null){
            eventOnCompletion.Invoke();
        }
        //SceneManager.LoadScene(2);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
