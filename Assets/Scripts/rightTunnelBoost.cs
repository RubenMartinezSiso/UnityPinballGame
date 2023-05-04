using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightTunnelBoost : MonoBehaviour
{
    private bool hasPassedZone = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            if (hasPassedZone)
            {
                Rigidbody rb = other.GetComponent<Rigidbody>();
                rb.AddForce(transform.forward * 10f, ForceMode.Impulse);
            }
            else
            {
                hasPassedZone = true;
            }
        }
    }
}
