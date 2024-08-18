using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class InstantiatingModel : MonoBehaviour
{
    public Vector3 loadPos = new Vector3(0,0,0);
    //public GameObject prefabToLoad;
    //public int currentModelIndex = 0;

public void LoadPrefab(GameObject prefabToLoad){
    Instantiate(prefabToLoad, loadPos, quaternion.identity);
} 

public void DestroyPrefab(){

    GameObject[] go;
    go = GameObject.FindGameObjectsWithTag("3DModel");
    Destroy(go[0]);
}
}
