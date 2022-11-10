using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
   
    public NavMeshAgent navMeshAgent;
    public GameObject player;
    public GameObject[] destinations; 
    public float distanceToFollowPlayer = 5f;
    Vector3 currentTarget; 
    int currentDestination = 0; 

    void Start()
    {
        currentTarget = destinations[currentDestination].transform.position; 
    }

    void Update()
    {
        if (Vector3.Distance(destinations[currentDestination].transform.position, transform.position) < 0.1f)
        {
            if (currentDestination == destinations.Length - 1)
            {
                currentDestination = 0; 
            }
            else 
            {
                currentDestination++;
            }
        }

        if (Vector3.Distance(player.transform.position, transform.position) < distanceToFollowPlayer) 
        {
            currentTarget = player.transform.position; 
        }
        else 
        {
            currentTarget = destinations[currentDestination].transform.position;
        }

        navMeshAgent.destination = currentTarget; 
    }
}