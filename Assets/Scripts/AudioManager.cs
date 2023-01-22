using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip collectibleAudio;
    public AudioClip levelClickSound;
    public AudioClip backButtonSound;
   
    public void PlayStartSound()
    {
        audioSource.Play();
    }

    public void LevelClickSound()
    {
        audioSource.PlayOneShot(levelClickSound);
    }
    public void BackButtonClick()
    {
        audioSource.PlayOneShot(backButtonSound);
    }
}
