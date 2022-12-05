using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
   
    private void OnTriggerEnter(Collider other)
    {
        Data.keys += 1;
        Destroy(gameObject,0.1f);
    }

}
