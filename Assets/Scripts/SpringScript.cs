using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class SpringScript : MonoBehaviour
{
    // Initial Z value of the scale
    const float initialZScaleValue = 1f;
    // Initial Z value of the position
    const float initialZPositionValue = -6f;
    // Time in seconds between every update of the spring's size
    const float delayValue = 0.05f;
    // How much the scale change every update of the spring's size
    const float scaleVariation = 0.012f;
    // Limit of scale reduction
    const float minimumScale = 0.10f;

    public float newZScale = initialZScaleValue;
    public float newZPosition = initialZPositionValue;
    public float delay = delayValue;
    float timer;
    public GameObject killball;
    public bool ballIn;
    LifesScript externalLifesScript;

    void Start()
    {
        ballIn = true;
        externalLifesScript = killball.GetComponent<LifesScript>();
    }

    void Update()
    {
        if (externalLifesScript.lifesLeft > 0 && ballIn)
        {
            // The player press the button
            if (Input.GetKey(KeyCode.Space))
            {
                timer += Time.deltaTime;
                if (timer > delay)
                {
                    if (newZScale >= minimumScale)
                    {
                        transform.localScale = new Vector3(gameObject.transform.localScale.x,
                                                            gameObject.transform.localScale.y,
                                                            newZScale);   // Change scale (just Z)
                        transform.position = new Vector3(gameObject.transform.localPosition.x,
                                                          gameObject.transform.localPosition.y,
                                                          newZPosition);  // Change position (just Z)

                        newZScale = newZScale - scaleVariation;           // Every update change his scale
                        newZPosition = newZPosition - scaleVariation / 2;   // Every update change his position (has to be the half of the change of newZScale)
                    }
                }
            }

            // The player release the button
            if (Input.GetKeyUp(KeyCode.Space))
            {
                // Reset scale and position
                newZScale = initialZScaleValue;
                newZPosition = initialZPositionValue;
                transform.localScale = new Vector3(gameObject.transform.localScale.x,
                                                            gameObject.transform.localScale.y,
                                                            initialZScaleValue);
                transform.position = new Vector3(gameObject.transform.localPosition.x,
                                                  gameObject.transform.localPosition.y,
                                                  initialZPositionValue);
            }
        }
    }
}
