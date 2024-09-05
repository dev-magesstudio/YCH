using UnityEngine;

public class BreathingEffect : MonoBehaviour
{
    // Variables to control the breathing effect
    public float minScale = 0.9f;  // Minimum scale factor
    public float maxScale = 1.1f;  // Maximum scale factor
    public float speed = 2.0f;     // Speed of the breathing effect

    private Vector3 initialScale;  // Store the initial scale of the object

    void Start()
    {
        // Save the initial scale of the GameObject
        initialScale = transform.localScale;
    }

    void Update()
    {
        // Calculate the scale factor using a sine wave
        float scaleFactor = Mathf.Lerp(minScale, maxScale, (Mathf.Sin(Time.time * speed) + 1.0f) / 2.0f);

        // Apply the scale factor to the GameObject
        transform.localScale = initialScale * scaleFactor;
    }
}
