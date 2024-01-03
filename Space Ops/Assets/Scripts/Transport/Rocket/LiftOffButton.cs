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
