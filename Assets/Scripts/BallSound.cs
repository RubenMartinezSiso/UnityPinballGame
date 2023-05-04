using UnityEngine;

public class BallSound : MonoBehaviour
{
    [SerializeField] private AudioClip soundBallFalling;
    [SerializeField] private AudioClip soundLifes;
    [SerializeField] private float volume = 10f;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = volume;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("KillBall"))
        {
            audioSource.PlayOneShot(soundBallFalling);
            audioSource.PlayOneShot(soundLifes);
        }
    }
}
