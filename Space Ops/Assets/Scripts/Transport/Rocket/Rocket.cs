using UnityEngine;


public class Rocket : Transport
{
    public Rigidbody rb;
    public float thrustForce;
    public float freezePosition;
    public bool applyThrust;
    

    void Start()
    {
        CacheRigidBody();
    }

    private void CacheRigidBody()
    {
        rb.GetComponent<Rigidbody>();
    }

    public void Thrusting()
    {
        rb.AddForce(Vector3.up * thrustForce, ForceMode.Force);       
    }

    
}
