using System.Collections;
using System.Collections.Generic;
using UnityEditor.Presets;
using UnityEngine;

public class FlipperScript : MonoBehaviour
{
    public float restPosition = 0f;
    public float pressedPosition = 45f;
    public float hitStrenght = 10000f;
    public float flipperDamper = 150f;
    public string inputName;
    HingeJoint hinge;
    public GameObject killball;
    LifesScript externalLifesScript;
    public AudioSource flipperSound;
    bool played = false;

    // Start is called before the first frame update
    void Start()
    {
        externalLifesScript = killball.GetComponent<LifesScript>();
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;
        flipperSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(externalLifesScript.lifesLeft > 0)
        {
            JointSpring spring = new JointSpring();
            spring.spring = hitStrenght;
            spring.damper = flipperDamper;

            if (Input.GetAxis(inputName) == 1)
            {
                spring.targetPosition = pressedPosition;
            }
            else
            {
                spring.targetPosition = restPosition;
            }
            if (spring.targetPosition == pressedPosition && !played)
            {
                flipperSound.Play();
                played = true;

            }
            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
            {
                played = false;
            }
            hinge.spring = spring;
            hinge.useLimits = true;
        }        
    }
}
