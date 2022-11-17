using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchState : MonoBehaviour
{


    public GameObject targetObject;
    public float changeStateTime;

    void Start()
    {
        InvokeRepeating("ChangeObjectState", 0f, changeStateTime);
    }

    void ChangeObjectState()
    {
        targetObject.SetActive(!targetObject.activeInHierarchy);    
    }


    void Update()
    {
        
    }
}
