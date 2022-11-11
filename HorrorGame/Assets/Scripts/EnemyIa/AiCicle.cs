using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiCicle : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;

    public GameObject destination1;

    public GameObject destination2;

    public GameObject destination3;


    void Start()
    {
        navMeshAgent.destination = destination1.transform.position;
    }

    
    void Update()

    {
     
        float distance = Vector3.Distance(transform.position, destination1.transform.position);
        if (distance<1)
        {
            navMeshAgent.destination = destination2.transform.position;
        }

        float distance2 = Vector3.Distance (transform.position, destination2.transform.position);
        if (distance < 1)
        {
            navMeshAgent.destination = destination3.transform.position;
        }
    }
}
