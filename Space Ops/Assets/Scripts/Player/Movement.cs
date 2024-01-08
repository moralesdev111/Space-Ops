using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] PlayerInput playerInput;
    [Header("Movement")]
    [SerializeField] float movementSpeed;
    [SerializeField] float groundDrag;

    [Header("Ground Check")]
    [SerializeField] float playerHeight;
    [SerializeField] LayerMask whatIsGround;
    public bool isGrounded;

    [SerializeField] Rigidbody rb;
    [SerializeField] Transform orientation;
    
    private Vector3 moveDirection;
    public Quest activeQuest;


    void Start()
    {
        FreezeRigidBodyRotation();
    }
    

    void Update()
    {        
        IsGroundedFlagCheck();
        SpeedControl();
        ApplyGroundDrag();
    }

    


    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void IsGroundedFlagCheck()
        {
            isGrounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 1.1f, whatIsGround);
        }
    private void ApplyGroundDrag()
    {
        if (isGrounded)
        {
            rb.drag = groundDrag;
        }
        else rb.drag = 0;
    }
    

    private void MovePlayer()
    {
        moveDirection = orientation.forward * playerInput.verticalInput + orientation.right * playerInput.horizontalInput;
        rb.AddForce(moveDirection*movementSpeed * 10f, ForceMode.Force);
    }

    private void SpeedControl()
    {
        Vector3 flatVelocity = new Vector3(rb.velocity.x,0f,rb.velocity.z);

        if(flatVelocity.magnitude > movementSpeed){
            Vector3 limitedVelocity = flatVelocity.normalized * movementSpeed;
            rb.velocity = new Vector3(limitedVelocity.x,rb.velocity.y, limitedVelocity.z);
        }
    }

    private void FreezeRigidBodyRotation()
    {
        rb.freezeRotation = true;
    }
}
