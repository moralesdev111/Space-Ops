using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandingButton : MonoBehaviour
{
    [SerializeField] Rocket rocket;
    [SerializeField] Canvas landingCanvas;
    [SerializeField] UIManager uIManager;
    [SerializeField] PlayerInput playerInput;


    private void OnTriggerStay(Collider collider)
    {
        if(collider.tag == "Player")
        {
            uIManager.TurnOnUI(landingCanvas);
            if(Input.GetKeyDown(playerInput.landing))
            {
                rocket.applyThrust = false;   
            }                     
        }
    }

    private void OnTriggerExit(Collider collider)
    {
         if(collider.tag == "Player")
        {           
            uIManager.TurnOffUI(landingCanvas);
            landingCanvas.gameObject.SetActive(false);                       
        }
    }    
}
