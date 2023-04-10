using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeDoor : MonoBehaviour
{
    public GameObject colliderObject;
    public GameObject spring;
    SpringScript externalSpringScript;

    private void Start()
    {
        externalSpringScript = spring.GetComponent<SpringScript>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Ball"))
        {
            externalSpringScript.ballIn = false;

            StartCoroutine(WaitASec());
        }
    }

    IEnumerator WaitASec()
    {
        yield return new WaitForSeconds(1f);
        colliderObject.GetComponent<Collider>().isTrigger = false;
    }
}