using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeCameraPositioner : MonoBehaviour
{
    public Vector3 targetPos = new Vector3(0,1,-10);
    //public Vector3 targetRot = new Vector3(0,0,0);
    // Start is called before the first frame update
    void Start()
    {
        transform.position = targetPos;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
