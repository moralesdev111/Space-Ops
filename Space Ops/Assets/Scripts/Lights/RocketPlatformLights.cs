using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketPlatformLights : MonoBehaviour
{
   [SerializeField] Rocket rocket;
   [SerializeField] Light pointLightColor;

    private Color liftOffColor = Color.red;

    private Color idleColor = Color.green;
    

    void Update()
    {
        ColorChanging();
    }

    private void ColorChanging()
    {
        if (rocket.idle == true)
        {
            pointLightColor.color = idleColor;
        }
        else
        {
            pointLightColor.color = liftOffColor;
        }
    }
}
