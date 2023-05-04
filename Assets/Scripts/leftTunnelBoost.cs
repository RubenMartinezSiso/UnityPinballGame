using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftTunnelBoost : MonoBehaviour
{
    public float impulse = 1f;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball")) // Si el objeto que colisiona tiene la etiqueta "Player"
        {
            Rigidbody rb = other.GetComponent<Rigidbody>(); // Accedemos al componente Rigidbody del objeto que colisiona
            rb.AddForce(transform.forward * impulse, ForceMode.Impulse); // Añadimos una fuerza de impulso hacia adelante en el objeto que colisiona
        }
    }
}