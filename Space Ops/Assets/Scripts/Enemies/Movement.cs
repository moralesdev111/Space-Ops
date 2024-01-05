using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Movement : MonoBehaviour
{
    [SerializeField] NavMeshAgent navMeshAgent;
    [SerializeField] Transform platform;
    private Vector3 destination;

    
    void Start()
    {
        SetAIDestination();
    }

    void Update()
    {
        MoveAIToDestination();
    }

    private void MoveAIToDestination()
    {
        navMeshAgent.destination = destination;
    }

    private void SetAIDestination()
    {
        destination = platform.position;
    }
}
