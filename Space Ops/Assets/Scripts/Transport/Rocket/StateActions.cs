using UnityEngine;

public class StateActions : MonoBehaviour
{
    [SerializeField] BankManager bankManager;
    [SerializeField] Radio radio;
    [SerializeField] AnimationManager animationManager;
    [SerializeField] SoundManager soundManager;
    [SerializeField] ParticleManager particleManager;    
    [SerializeField] Rocket rocket;
    [SerializeField] States states;
    [SerializeField] RocketPlatformLights rocketPlatformLights;

    private bool coinAdded = false;
    
    

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


           coinAdded = false;
            soundManager.sfxPlayed = false;
            /*if(animationManager.compartmentAlreadyClosed == false)
            {
                animationManager.CompartmentClose();
            }     */                           
            particleManager.TurnOffParticleSystem(particleManager.trails);
            particleManager.TurnOffParticleSystem(particleManager.bigSmoke);
         
            rocketPlatformLights.SetLightColor(rocketPlatformLights.greenColor);



        }
        if(states.currentState == States.RocketStates.liftoff)
        {

           //animationManager.ResetAnimatorParameters();
            rocket.Thrusting();
            particleManager.TurnOnParticleSystem(particleManager.bigSmoke);
            rocketPlatformLights.SetLightColor(rocketPlatformLights.redColor);
            soundManager.PlaySFX("Rocket");
            
            
        }
        if(states.currentState == States.RocketStates.frozen)
        {


            particleManager.TurnOffParticleSystem(particleManager.bigSmoke);
            rocketPlatformLights.SetLightColor(rocketPlatformLights.cyanColor);
            Freeze();
            radio.PlayRadioIntroductionMessage(radio.radioIntroductionClip);
            
        }
        if(states.currentState == States.RocketStates.landing)
        {
            
            UnFreeze(); 
            particleManager.TurnOnParticleSystem(particleManager.trails);                    
            rocketPlatformLights.SetLightColor(rocketPlatformLights.yellowColor);
            
        }
        if(states.currentState == States.RocketStates.landed)
        {


            rocketPlatformLights.SetLightColor(rocketPlatformLights.greenColor);
            if(bankManager.coinCanBeAdded && coinAdded == false)
            {
                bankManager.AddBalance(1);    
                coinAdded = true;            
            }
            
            
             
            
            particleManager.TurnOffParticleSystem(particleManager.trails);            
            //animationManager.CompartmentOpen();
            
                    
            

        }
    }    
}
