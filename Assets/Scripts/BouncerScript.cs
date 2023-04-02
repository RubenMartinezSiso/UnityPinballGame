using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncerScript : MonoBehaviour
{
    [SerializeField] private float pointNumber = 10;
    [SerializeField] private points punctuation;


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Ball"))
        {
            punctuation.AddPoints(pointNumber);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            punctuation.AddPoints(pointNumber);
        }
    }
}
