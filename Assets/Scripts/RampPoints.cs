using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RampPoints : MonoBehaviour
{
    [SerializeField] private float pointNumber = 25;
    [SerializeField] private points punctuation;
    private float lastCollision = 0f;
    
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Ball"))
        {
            float currentTime = Time.time;

            if(currentTime - lastCollision >= 2f)
            {
                punctuation.AddPoints(pointNumber);
                lastCollision = currentTime;
            }
        }
    }
}
