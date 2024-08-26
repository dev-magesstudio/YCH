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
    // for(int i=0; i<go.Count; i++){
    //     Resources.UnloadAsset(go[i].gameObject);
    // }
   Destroy(go[0]);
    //ModelInstantiatorManager.instance.prefabsToBeLoaded[index] = null;
    
    go.Clear();
    GC.Collect();
   //go[0].SetActive(false);
    Resources.UnloadUnusedAssets();
   //EditorUtility.UnloadUnusedAssetsImmediate();
    
}
public void DestroySeqOneAndTwoPrefabs(){
    
   foreach(GameObject objectToBeDestroyed in GameObject.FindGameObjectsWithTag("3DModel")){
        go.Add(objectToBeDestroyed);
    }
    Destroy(go[0].gameObject);
    Destroy(go[1].gameObject);
    //go[0].SetActive(false);
    //go[1].SetActive(false);
    //Resources.UnloadUnusedAssets();
    //EditorUtility.UnloadUnusedAssetsImmediate();

    go.Clear();
    GC.Collect();
   //go[0].SetActive(false);
    Resources.UnloadUnusedAssets();
}
}
