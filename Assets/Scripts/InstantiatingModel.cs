using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.Mathematics;
using UnityEditor;
using UnityEngine;

public class InstantiatingModel : MonoBehaviour
{
    public Vector3 loadPos = new Vector3(0, 0, 0);
    List<GameObject> go = new();


    //Instantiates next model
    public void LoadPrefab(int modelCount)
    {
        ModelInstantiatorManager.instance.LoadPrefabsFromName(modelCount);
    }


    //Used to destroy the previous models to free up memory
    public void DestroyPrefab()
    {
        foreach (GameObject objectToBeDestroyed in GameObject.FindGameObjectsWithTag("3DModel"))
        {
            go.Add(objectToBeDestroyed);
        }
        Destroy(go[0]);
        //go.Clear();
        GC.Collect();
        Resources.UnloadUnusedAssets();

    }

    //Used in Seq 105 to destroy the cloud model
    public void DestroyCloudPrefab()
    {

        foreach (GameObject objectToBeDestroyed in GameObject.FindGameObjectsWithTag("3DModel"))
        {
            go.Add(objectToBeDestroyed);
        }
        Destroy(go[1].gameObject);
        //Destroy(go[1].gameObject);

        go.Clear();
        GC.Collect();
        Resources.UnloadUnusedAssets();
    }

    //Function for disabling the bounding box that has particle effect (To be used in end where we need user to tap on the logo for restart)
    public void DisableBoundingCanvas()
    {
        GameObject boundingCanvas = GameObject.FindGameObjectWithTag("BoundingCanvas");
        boundingCanvas.SetActive(false);

    }
}
