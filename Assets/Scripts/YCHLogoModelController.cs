using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class YCHLogoModelController : MonoBehaviour
{
    public Vector3 newTransform = new Vector3(0,0.698f, 0.379f);
    public Vector3 newScale = new Vector3(0.2f,0.2f,0.2f);
    public Vector3 newRotation = new Vector3(0,180,0);


    public void SetTransformOfGamebject(){
        gameObject.transform.localPosition = newTransform;
        gameObject.transform.localScale = newScale;
        gameObject.transform.localRotation = Quaternion.Euler(newRotation);

    }
   
}
