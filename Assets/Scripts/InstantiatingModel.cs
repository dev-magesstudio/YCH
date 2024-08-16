using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class InstantiatingModel : MonoBehaviour
{

    //public GameObject prefabToLoad;
    //public int currentModelIndex = 0;

public void LoadPrefab(GameObject prefabToLoad){
    Instantiate(prefabToLoad, new Vector3(0,0,0), quaternion.identity);
} 

public void DestroyPrefab(){

    GameObject[] go;
    go = GameObject.FindGameObjectsWithTag("3DModel");
    Destroy(go[0]);
}
}
