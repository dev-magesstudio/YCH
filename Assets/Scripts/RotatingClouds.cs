using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingClouds : MonoBehaviour
{
    public float rotSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right * rotSpeed * Time.deltaTime);
    }
}