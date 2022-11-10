using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiEnemy : MonoBehaviour
{

    public Transform Objetivo;
    public float velocidad;
    public NavMeshAgent IA;

    public Animation Anim;
    public string NombreAnimacionCaminar;
    public string NombreAnimacionAtacar;

   

    
    void Update()
    {
        IA.speed = velocidad;
        IA.SetDestination(Objetivo.position);


        if (IA.velocity == Vector3.zero)
        {
            Anim.CrossFade(NombreAnimacionAtacar);
        }
        else
        {
            Anim.CrossFade(NombreAnimacionCaminar);
        }
    }
}
