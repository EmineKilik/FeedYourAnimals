using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 40.0f;

    void Start()
    {
        
    }

    //Ýleriye doðru hareket saðlar.
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
