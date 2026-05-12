using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionDetection : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("Caja"))
        {
            FindObjectOfType<Tiempo>().gameOver = true;

            Destroy(gameObject);
        }
    }
}
