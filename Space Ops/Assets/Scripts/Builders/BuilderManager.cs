using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuilderManager : MonoBehaviour
{
    [SerializeField] GameObject builder;
    [SerializeField] Transform spawnPoint;
    public bool builderInstantiated = false;
  

    public void InvokeInstantiateOneBuilder(float delay)
    {
        Invoke("InstantiateOneBuilder",delay);
        builderInstantiated = true;
    }
    public void InstantiateOneBuilder()
    {
        Instantiate(builder, spawnPoint.position, Quaternion.identity);
        builderInstantiated = true;
    }

    public bool ResetBuilderInstantiated()
    {
        return builderInstantiated = false;
    }
}
