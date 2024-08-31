using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.Mathematics;
using UnityEditor;
using UnityEngine;

public class InstantiatingModel : MonoBehaviour
{
    public Vector3 loadPos = new Vector3(0,0,0);
    List<GameObject> go = new ();

    //public List<GameObject> prefabsToBeLoaded = new();
    //public List<Vector3> loadPositions = new();
    //public int modelCount;

    
    //public GameObject prefabToLoad;
    //public int currentModelIndex = 0;

public void LoadPrefab(int modelCount){
    //StartCoroutine(LoadNextModel(prefabToLoad));
    ModelInstantiatorManager.instance.LoadPrefabsFromName(modelCount);
    //Instantiate(prefabsToBeLoaded[index], loadPositions[index], quaternion.identity);
    
} 

// IEnumerator LoadNextModel(GameObject prefabModel){
//     yield return null;
//     Instantiate(prefabModel, loadPos, quaternion.identity);
// }
public void DestroyPrefab(){
    foreach(GameObject objectToBeDestroyed in GameObject.FindGameObjectsWithTag("3DModel")){
        go.Add(objectToBeDestroyed);
    }
   Destroy(go[0]);    
    //go.Clear();
    GC.Collect();
    Resources.UnloadUnusedAssets();
    
}
public void DestroyCloudPrefab(){
    
   foreach(GameObject objectToBeDestroyed in GameObject.FindGameObjectsWithTag("3DModel")){
        go.Add(objectToBeDestroyed);
    }
    Destroy(go[1].gameObject);
    //Destroy(go[1].gameObject);

    go.Clear();
    GC.Collect();
    Resources.UnloadUnusedAssets();
}
}
