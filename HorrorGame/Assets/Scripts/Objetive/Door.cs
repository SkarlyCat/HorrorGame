using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public int keys;
    void Update()
    {
        keys = Data.keys;
        if (Data.keys>= 3)
        {
            Destroy(gameObject,0.1f);
        }

    }
}
