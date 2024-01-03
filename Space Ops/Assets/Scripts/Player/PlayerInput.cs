using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{    
    [HideInInspector] public float horizontalInput;
    [HideInInspector] public float verticalInput;
    

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
