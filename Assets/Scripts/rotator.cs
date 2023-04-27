using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotator : MonoBehaviour
{
    public float turningForce = 10f;
    public Vector3 turningPoint1;
    public Vector3 turningPoint2;

 
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.contacts[0].point == turningPoint1 || collision.contacts[0].point == turningPoint2)
        {
            GetComponent<Rigidbody>().AddTorque(transform.up * turningForce);
        }
    }
}
