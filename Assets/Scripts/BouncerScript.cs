using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncerScript : MonoBehaviour
{
    [SerializeField] private float pointNumber = 10;
    [SerializeField] private points punctuation;
    private AudioSource sound;

    private void Start()
    {
        sound = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Ball"))
        {
            sound.Play();
            //SoundController.Instance.ExecuteSound(sound);
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
