using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaMovement : MonoBehaviour
{
    public float velocidad = 3f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.down * velocidad * Time.deltaTime);
    }
}
