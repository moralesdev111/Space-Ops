using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverrideRocketState : MonoBehaviour
{
    [SerializeField] States states;
    void Start()
    {
        states.enabled = false;
    }

    void Update()
    {
        states.currentState = States.RocketStates.landed;
    }
}
