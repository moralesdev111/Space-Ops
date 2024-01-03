using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandingButton : MonoBehaviour
{
    [SerializeField] Rocket rocket;

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.tag == "Player")
        {
            rocket.applyThrust = false;            
        }
    }
}
