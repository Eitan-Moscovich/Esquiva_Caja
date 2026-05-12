using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tiempo : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public bool gameOver = false;

    void Update()
    {
        if(gameOver == false)
        {
            timerText.text = "Tiempo: " + Time.time.ToString("F2");
        }
    }
}