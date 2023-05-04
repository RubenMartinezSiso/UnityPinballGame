using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeDoor : MonoBehaviour
{
    public GameObject colliderObject;
    public GameObject spring;
    SpringScript externalSpringScript;
    [SerializeField] private float volume = 10f;
    [SerializeField] private AudioSource soundBallMoving;
    public GameObject killball;
    private LifesScript externalLifesScript;

    private void Start()
    {
        externalSpringScript = spring.GetComponent<SpringScript>();
        soundBallMoving = GetComponent<AudioSource>();
        soundBallMoving.volume = volume;
        externalLifesScript = killball.GetComponent<LifesScript>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Ball") && soundBallMoving != null)
        {
            externalSpringScript.ballIn = false;
            soundBallMoving.Play();

            StartCoroutine(WaitASec());
        }
    }

    IEnumerator WaitASec()
    {
        yield return new WaitForSeconds(1f);
        colliderObject.GetComponent<Collider>().isTrigger = false;
    }

    private void Update()
    {
        if(externalSpringScript.ballIn || externalLifesScript.lifesLeft <= 0)
        {
            soundBallMoving.Stop();
        }
    }
}