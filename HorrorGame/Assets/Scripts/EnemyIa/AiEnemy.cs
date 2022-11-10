using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiEnemy : MonoBehaviour
{

    public Transform Objetivo;
    public float velocidad;
    public NavMeshAgent IA;

   

    
    void Update()
    {
        IA.speed = velocidad;
        IA.SetDestination(Objetivo.position);
    }
}
