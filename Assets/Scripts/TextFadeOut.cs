using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextFadeOut : MonoBehaviour
{
     public Material[] targetMaterials;  // Assign your materials in the Inspector
    public float duration = 2.0f;       // Duration of the fade-out

    private float timeElapsed = 0.0f;
    private Color[] startColors;
    private Color[] endColors;

    public bool shouldBeOpaqueInBeginning = false;
    private bool isFadingOut = false;   // Flag to control the fade-out process
    // Start is called before the first frame update
    void Start()
    {
        // Initialize arrays based on the number of materials
        startColors = new Color[targetMaterials.Length];
        endColors = new Color[targetMaterials.Length];

        // Set up start (fully opaque) and end (fully transparent) colors for each material
        for (int i = 0; i < targetMaterials.Length; i++)
        {
            startColors[i] = targetMaterials[i].color;
            startColors[i].a = 1.0f;

            endColors[i] = startColors[i];
            endColors[i].a = 0.0f;

            // Ensure each material starts fully opaque
            if(shouldBeOpaqueInBeginning)
                targetMaterials[i].color = startColors[i];
            
        }
        

        
    }

    // Update is called once per frame
    void Update()
    {
        if (isFadingOut)
        {
            if (timeElapsed < duration)
            {
                timeElapsed += Time.deltaTime;
                float percentageComplete = timeElapsed / duration;

                // Interpolate the alpha value for each material
                for (int i = 0; i < targetMaterials.Length; i++)
                {
                    Color newColor = Color.Lerp(startColors[i], endColors[i], percentageComplete);
                    targetMaterials[i].color = newColor;
                }

                // Stop fading when complete
                if (percentageComplete >= 1.0f)
                {
                    isFadingOut = false;
                }
            }
        }
    }

    public void StartFadeOut(){
        isFadingOut = true;
    }
}
