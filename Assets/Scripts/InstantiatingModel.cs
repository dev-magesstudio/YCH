using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class InstantiatingModel : MonoBehaviour
{
    public GameObject prefabToLoad;
public void LoadPrefab(){
    Instantiate(prefabToLoad, new Vector3(0,0,0), quaternion.identity);
}

public void DestroyPrefab(){

    GameObject[] go;
    go = GameObject.FindGameObjectsWithTag("3DModel");
    Destroy(go[0]);
}
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadPrefab", 2);
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
