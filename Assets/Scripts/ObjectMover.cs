using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    public Transform targetPosition; // The target position object
    public float moveDuration = 2.0f; // Duration to move towards the target
    public float scaleMultiplier = 3.0f; // How much the object should scale
    public AnimationCurve movementCurve; // Optional: Curve to control movement
    public AnimationCurve scaleCurve; // Optional: Curve to control scaling

    private Vector3 initialPosition;
    private Vector3 initialScale;
    private bool isAnimating = false;
    private float elapsedTime = 0f;

    void Start()
    {
        initialPosition = transform.position;
        initialScale = transform.localScale;
    }

    void Update()
    {
        if (isAnimating)
        {
            elapsedTime += Time.deltaTime;
            float t = Mathf.Clamp01(elapsedTime / moveDuration);

            // Move the object
            transform.position = Vector3.Lerp(initialPosition, targetPosition.position, movementCurve.Evaluate(t));

            // Scale the object
            transform.localScale = Vector3.Lerp(initialScale, initialScale * scaleMultiplier, scaleCurve.Evaluate(t));

            // Stop animation when finished
            if (t >= 1.0f)
            {
                isAnimating = false;
            }
        }
    }

    public void StartAnimation()
    {
        if (!isAnimating)
        {
            isAnimating = true;
            elapsedTime = 0f;
        }
    }
}
