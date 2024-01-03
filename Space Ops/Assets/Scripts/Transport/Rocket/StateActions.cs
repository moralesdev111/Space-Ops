using UnityEngine;

public class StateActions : MonoBehaviour
{
    [SerializeField] Rocket rocket;
    [SerializeField] States states;
    [SerializeField] RocketPlatformLights rocketPlatformLights;

    private void Update()
    {
        StatesActions();
    }

    

    public void Freeze()
    {
        rocket.rb.constraints = RigidbodyConstraints.FreezePosition;
    }

    public void UnFreeze()
    {
        rocket.rb.constraints = RigidbodyConstraints.None;
    }
    
    private void StatesActions()
    {
        if(states.currentState == States.RocketStates.idle)
        {
            rocketPlatformLights.SetLightColorGreen();
        }
        if(states.currentState == States.RocketStates.liftoff)
        {
            rocket.Thrusting();
            rocketPlatformLights.SetLightColorRed();
            
        }
        if(states.currentState == States.RocketStates.frozen)
        {
            Freeze();
        }
        if(states.currentState == States.RocketStates.landing)
        {
            UnFreeze();
        }
        if(states.currentState == States.RocketStates.landing)
        {
            return;
        }
        if(states.currentState == States.RocketStates.landingTwo)
        {
            return;
        }

    }
}
