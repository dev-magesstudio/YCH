using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeCameraPositioner : MonoBehaviour
{
    public GameObject polySpatialVolumeCameraPrefab;  // Assign the PolySpatial Volume Camera prefab in the inspector
    public float distanceInFrontOfUser = 2.0f;        // Set the distance to place the camera in front of the user

    void Start()
    {
        LaunchPolySpatialVolumeCamera();
    }

    void LaunchPolySpatialVolumeCamera()
    {
        // Get the main camera's position and forward direction
        Vector3 userPosition = Camera.main.transform.position;
        Vector3 userForward = Camera.main.transform.forward;

        // Calculate the position in front of the user
        Vector3 cameraPosition = userPosition + userForward * distanceInFrontOfUser;

        // Instantiate the PolySpatial Volume Camera at the calculated position
        Instantiate(polySpatialVolumeCameraPrefab, cameraPosition, Quaternion.LookRotation(userForward));
    }
}
