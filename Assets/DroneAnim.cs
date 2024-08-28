using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneAnim : MonoBehaviour
{
    public GameObject logo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayNextAnim()
    {
        logo.GetComponent<Animator>().enabled = true;
    }
}
