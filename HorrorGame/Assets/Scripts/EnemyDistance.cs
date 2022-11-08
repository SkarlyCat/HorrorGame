using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDistance : MonoBehaviour
{
    MeshRenderer mesh;
    public Transform playerTarget;

    float time = 10;

    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();

        mesh.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        float distancia = Vector3.Distance(transform.position, playerTarget.position);

        if (distancia < 6)
        {
            mesh.enabled = true;
        }
        else
        {
            mesh.enabled = false;
        }


        time -= Time.deltaTime;

        if(time <= 0)
        {
            time = 10;
        }
    }


}
