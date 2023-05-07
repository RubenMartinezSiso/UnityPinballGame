using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tunnelPoints : MonoBehaviour
{
    [SerializeField] private float pointNumber = 25;
    [SerializeField] private points punctuation;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            punctuation.AddPoints(pointNumber);
        }
    }
}
