using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeDoor : MonoBehaviour
{
    public GameObject colliderObject;
    private void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Ball"))
        {
            StartCoroutine(WaitASec());
        }
    }

    IEnumerator WaitASec()
    {
        yield return new WaitForSeconds(1f);
        colliderObject.GetComponent<Collider>().isTrigger = false;
    }
}