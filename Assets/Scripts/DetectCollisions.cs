using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    //Birbirine de�en nesneleri yok eder.
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
