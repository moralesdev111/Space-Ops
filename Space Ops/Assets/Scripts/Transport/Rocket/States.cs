using UnityEngine;

public class States : MonoBehaviour
{
    [SerializeField] Rocket rocket;
    [Header("Current Rocket State")]
    public RocketStates currentState;
    private float timeSinceLanding;
 
    

    public enum RocketStates
    {
        idle,
        liftoff,
        frozen,
        landing,
        landed
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
            
            if (rocket.transform.position.y >= rocket.freezePosition)
            {
                nextState = RocketStates.frozen; // Change to frozen when condition met
            }
            break;
        case RocketStates.frozen:
            
            if (!rocket.applyThrust)
            {
                nextState = RocketStates.landing; // Change to landing when condition met
            }
            break;
        case RocketStates.landing:
           
            if (rocket.transform.position.y <= 8 )
            {
                nextState = RocketStates.landed; // Change to landingTwo when condition met
            }
            break;
        case RocketStates.landed:

            timeSinceLanding+= Time.deltaTime;
            if (timeSinceLanding >= 30f)
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
