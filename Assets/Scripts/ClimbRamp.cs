using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimbRamp : MonoBehaviour
{
    public float additionalVelocity = 10f;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Ball"))
        {
            Rigidbody rb = collision.collider.GetComponent<Rigidbody>();
            if (rb != null)
            {
                Vector3 normal = collision.contacts[0].normal;
                Vector3 forceDirection = Vector3.Reflect(rb.velocity.normalized, normal); // dirección del impulso en función de la pendiente
                rb.AddForce(forceDirection * additionalVelocity, ForceMode.Impulse);
            };
        }
    }
}
