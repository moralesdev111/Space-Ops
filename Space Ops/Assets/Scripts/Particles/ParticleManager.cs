using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : MonoBehaviour
{
    public ParticleSystem bigSmoke;
    public ParticleSystem trails;

    public void TurnOnParticleSystem(ParticleSystem particleSystem)
    {
        particleSystem.gameObject.SetActive(true);
    }

    public void TurnOffParticleSystem(ParticleSystem particleSystem)
    {
        particleSystem.gameObject.SetActive(false);
    }
}
