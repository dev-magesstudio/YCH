using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;
using UnityEditor;


public class ModelInstantiatorManager : MonoBehaviour
{
    public static ModelInstantiatorManager instance;

    public List<string> prefabsToLoadStrings = new();

    void Awake()
    {
        if (instance != this && instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
    }
    public List<GameObject> prefabsToBeLoaded = new();
    public List<Vector3> loadPositions = new();
    public Vector3 loadPos = new Vector3(0, 0.5f, 2);

    //Function that loads the prefab -- Not in use as of now!  
    public void LoadPrefab(int index)
    {
        Instantiate(prefabsToBeLoaded[index], loadPositions[index], quaternion.identity);
    }

    //Memory Management Used - Load Prefab from Resources and then name of the prefab
    public void LoadPrefabsFromName(int index)
    {
        GameObject go = Resources.Load<GameObject>("Models/" + prefabsToLoadStrings[index]);
        Instantiate(go);
    }
}
