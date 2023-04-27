using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class OptionsScript : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;
    public void FullScreen(bool fllscreen)
    {
        Screen.fullScreen = fllscreen;
    }

    public void ChangeVolume(float volume)
    {
        audioMixer.SetFloat("Volume", volume);
    }

    public void ChangeQuality(int index)
    {
        QualitySettings.SetQualityLevel(index);
    }
}
