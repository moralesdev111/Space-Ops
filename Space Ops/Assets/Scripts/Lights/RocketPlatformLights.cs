using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketPlatformLights : MonoBehaviour
{

    private Light[] pointLights;
    public Color redColor = Color.red;
    public Color greenColor = Color.green;
    public Color yellowColor = Color.yellow;
    public Color cyanColor = Color.cyan;


    
    void Start()
    {
        GetLightArrayInChilds();
    }
    
    void GetLightArrayInChilds()
    {
        pointLights = GetComponentsInChildren<Light>();       
    }

    public void SetLightColor(Color color)
    {        
        foreach (Light light in pointLights)
        {
            light.color = color;
        }
    }
}

    
     

