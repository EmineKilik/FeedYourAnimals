using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 40.0f;

    void Start()
    {
        
    }

    //�leriye do�ru hareket sa�lar.
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
