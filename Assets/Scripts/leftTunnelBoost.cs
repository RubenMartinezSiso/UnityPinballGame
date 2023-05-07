using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftTunnelBoost : MonoBehaviour
{
    public float impulse = 1f;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * impulse, ForceMode.Impulse);
        }
    }
}