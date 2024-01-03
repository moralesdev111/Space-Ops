using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketPlatformLights : MonoBehaviour
{

   public Light[] pointLights;
    private Color redColor = Color.red;
    private Color greenColor = Color.green;
    
    void Start()
    {
        GetLightArrayInChilds();
    }
    
    void GetLightArrayInChilds()
    {
        pointLights = GetComponentsInChildren<Light>();       
    }

    public void SetLightColorRed()
    {
        foreach (Light light in pointLights)
        {
            light.color = redColor;
        }
    }

    public void SetLightColorGreen()
    {
        foreach (Light light in pointLights)
        {
            light.color = greenColor;
        }
    }

    

}
