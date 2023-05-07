using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LifesScript : MonoBehaviour
{
    public GameObject ball;
    public Image[] lifeImages;
    public int lifesLeft;
    public TextMeshProUGUI loseText;
    public GameObject spring;
    SpringScript externalScriptInstance;
    public bool plungeractive;

    void Start()
    {
        lifesLeft = 3;
        loseText.gameObject.SetActive(false);
        externalScriptInstance = spring.GetComponent<SpringScript>();
        plungeractive = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            lifesLeft--;
            UpdateLifes();

            if (lifesLeft <= 0)
            {
                loseText.gameObject.SetActive(true);
                externalScriptInstance.ballIn = false;
                plungeractive = false;
            }
        }
    }

    void UpdateLifes()
    {
        for (int i = 0; i < lifeImages.Length; i++)
        {
            if (i < lifesLeft)
            {
                lifeImages[i].gameObject.SetActive(true);
            }
            else
            {
                lifeImages[i].gameObject.SetActive(false);
            }
        }
    }
}
