using UnityEngine;

public class CameraCullingSphere : MonoBehaviour
{
    public Camera camera;               // Camera to apply culling to
    public Transform sphereTransform;   // Transform of the sphere
    public float sphereRadius = 10f;    // Radius of the sphere for culling
    public LayerMask culledLayerMask;   // LayerMask for the objects to be considered for culling

    private void LateUpdate()
    {
        if (camera == null || sphereTransform == null)
            return;

        // Create a mask that will be used to determine which objects are inside the sphere
        int originalCullingMask = camera.cullingMask;

        // Initialize a new culling mask
        int newCullingMask = 0;

        // Loop through all objects in the culled layer
        foreach (Renderer renderer in FindObjectsOfType<Renderer>())
        {
            if ((culledLayerMask & (1 << renderer.gameObject.layer)) != 0)
            {
                Vector3 objectPosition = renderer.transform.position;
                float distance = Vector3.Distance(objectPosition, sphereTransform.position);

                // Check if the object is within the sphere
                if (distance <= sphereRadius)
                {
                    // Add the object's layer to the new culling mask
                    newCullingMask |= (1 << renderer.gameObject.layer);
                }
            }
        }

        // Apply the new culling mask to the camera
        camera.cullingMask = newCullingMask;
    }
}
