using UnityEngine;

public class LiftOffButton : MonoBehaviour
{
   [SerializeField] Rocket rocket;
   [SerializeField] Canvas liftoffCanvas;
   [SerializeField] UIManager uIManager;
   [SerializeField] PlayerInput playerInput;
   

    private void OnTriggerStay(Collider collider)
    {
        if(collider.tag == "Player")
        {         
            uIManager.TurnOnUI(liftoffCanvas);
            if(Input.GetKeyDown(playerInput.liftOff))
            {                
            rocket.applyThrust = true;   
            }                     
        }        
    }

    private void OnTriggerExit(Collider collider)
    {
         if(collider.tag == "Player")
        {           
            uIManager.TurnOffUI(liftoffCanvas);
            liftoffCanvas.gameObject.SetActive(false);                       
        }
    }    
}
