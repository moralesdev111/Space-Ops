using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftOffButton : MonoBehaviour
{
   [SerializeField] Rocket rocket;

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.tag == "Player")
        {
            rocket.applyThrust = true;            
        }
    }
    
}
