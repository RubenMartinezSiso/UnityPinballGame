using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimbRamp : MonoBehaviour
{
    public float additionalVelocity = 5f;
    public float gravityScale = 0.5f;

    private Rigidbody ballRigidbody;
    private Vector3 rampDirection;
    // Start is called before the first frame update
    void Start()
    {
        ballRigidbody = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ramp"))
        {
            rampDirection = collision.contacts[0].normal;
            ballRigidbody.useGravity = false;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ramp"))
        {
            ballRigidbody.useGravity = true;
        }
    }

    private void FixedUpdate()
    {
        if (rampDirection != Vector3.zero)
        {
            Vector3 direccionAdicional = rampDirection * additionalVelocity;
            ballRigidbody.AddForce(direccionAdicional, ForceMode.Acceleration);
            ballRigidbody.AddForce(Physics.gravity * (gravityScale - 1), ForceMode.Acceleration);
        }
    }
}
