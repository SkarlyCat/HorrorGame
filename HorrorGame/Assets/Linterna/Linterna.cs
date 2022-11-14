using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Linterna : MonoBehaviour
{
    public Light luzLinterna;
    public bool activLight;
    public bool linternaEnMano;
    public float cantBateria = 100;
    public float perdidaBateria = 0.5f;

 

    void Update()
    {

      


        if (Input.GetMouseButtonDown(1) && linternaEnMano == true)
        {
            activLight = !activLight;

            if (activLight == true)
            {
                luzLinterna.enabled = true;
            }

            if (activLight == false)
            {
                luzLinterna.enabled = false;
            }
        }

       
    }
}
