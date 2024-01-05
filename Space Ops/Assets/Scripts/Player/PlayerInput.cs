using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{    
    [HideInInspector] public float horizontalInput;
    [HideInInspector] public float verticalInput;

    [Header("Keybinds for Rocket Interactions")]
    public KeyCode liftOff = KeyCode.L;
    public KeyCode landing = KeyCode.R;
    

    void Update()
    {
        AxisInput();
    }

    private void AxisInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }
   
}
