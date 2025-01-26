using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioClip[] sfxClips;
    public AudioSource sfxAudioSource;

    public void PlaySoundEffect(int index)
    {
        sfxAudioSource.clip = sfxClips[index];
        sfxAudioSource.Play();
    }
}
