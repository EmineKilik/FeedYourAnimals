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

    //Birbirine değen nesneleri yok eder.
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
