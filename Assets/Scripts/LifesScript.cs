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

    // Start is called before the first frame update
    void Start()
    {
        lifesLeft = 3;
        Debug.Log("You have " + lifesLeft + " lives");
        loseText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            lifesLeft--;
            UpdateLifes();

            if (lifesLeft <= 0)
            {
                Debug.Log("You lose");
                loseText.gameObject.SetActive(true);
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
