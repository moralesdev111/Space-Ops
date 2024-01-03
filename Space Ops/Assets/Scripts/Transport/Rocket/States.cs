using UnityEngine;

public class States : MonoBehaviour
{
    public RocketStates currentState;
    [SerializeField] Rocket rocket;
    

    public enum RocketStates
    {
        idle,
        liftoff,
        frozen,
        landing,
        landingTwo
    }

    void Update()
    {
        StateMachine();       
    }

   
    private RocketStates StateMachine()
    {
    RocketStates nextState = currentState; // Store the next state temporarily

    switch (currentState)
    {
        case RocketStates.idle:
            if (rocket.applyThrust)
            {
                nextState = RocketStates.liftoff; // Change to liftoff only when applying thrust
            }
            break;
        case RocketStates.liftoff:
            
            if (rocket.transform.position.y >= rocket.freezePosition && rocket.applyThrust)
            {
                nextState = RocketStates.frozen; // Change to frozen when condition met
            }
            break;
        case RocketStates.frozen:
            
            if (rocket.transform.position.y >= rocket.freezePosition && !rocket.applyThrust)
            {
                nextState = RocketStates.landing; // Change to landing when condition met
            }
            break;
        case RocketStates.landing:
           
            if (rocket.transform.position.y >= 2 && rocket.transform.position.y <= rocket.freezePosition && !rocket.applyThrust)
            {
                nextState = RocketStates.landingTwo; // Change to landingTwo when condition met
            }
            break;
        case RocketStates.landingTwo:
            if (rocket.transform.position.y <= 2 && rocket.transform.position.y <= rocket.freezePosition && !rocket.applyThrust)
            {
                nextState = RocketStates.idle; // Change to idle when condition met
            }
            break;
        default:
            break;
         }
    currentState = nextState; // Update currentState with nextState
    return currentState; // Return the updated currentState
    }
}
