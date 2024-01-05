using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BuilderMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    private float distanceMoved = 0f;
    private bool initialOrderComplete = false;
   

    void Update()
    {
        CheckIfYouCanStillMove();
    }

    private void CheckIfYouCanStillMove()
    {
        if (!initialOrderComplete && distanceMoved <= 45f)
        {
            InitialMoveOrder();
        }
    }

    void InitialMoveOrder()
    {
        float distanceToMove = moveSpeed * Time.deltaTime;
        transform.Translate(Vector3.back * moveSpeed * Time.deltaTime); 
        distanceMoved+= Mathf.Abs(distanceToMove);        
    }
}
