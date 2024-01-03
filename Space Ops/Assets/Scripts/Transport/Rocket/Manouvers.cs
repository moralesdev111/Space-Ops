using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manouvers : MonoBehaviour
{
    [SerializeField] Rocket rocket;

    private void Update()
    {
        ThrustCycle();
    }

    private void ThrustCycle()
    {
        rocket.idle = true;
        if (rocket.applyThrust == true)
        {
            //lifting state
            rocket.idle = false;
            rocket.Thrusting();
        }
        if (rocket.transform.position.y >= rocket.freezePosition && rocket.applyThrust == true)
        { 
            //frozen state
            rocket.idle = false;
            Freeze();
        }
        else if(rocket.transform.position.y >= rocket.freezePosition && rocket.applyThrust == false)
        {
            //landing state
            rocket.idle = false;
            UnFreeze();
        }
        else if(rocket.transform.position.y >= 2 && rocket.transform.position.y <= rocket.freezePosition && rocket.applyThrust == false)
        {
            //idle state
            rocket.idle = false;
        }
    }

    private void Freeze()
    {
        rocket.rb.constraints = RigidbodyConstraints.FreezePosition;
    }

    private void UnFreeze()
    {
        rocket.rb.constraints = RigidbodyConstraints.None;
    }
    
}
