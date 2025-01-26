using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioClip[] sfxClips;
    public AudioClip[] gameEndedClips;

    public AudioSource sfxAudioSource;
    public AudioSource gameEndedSource;

    public void PlaySoundEffect(int index)
    {
        sfxAudioSource.clip = sfxClips[index];
        sfxAudioSource.Play();
    }

    public void PlayGameEndedEffect(int index)
    {
        gameEndedSource.clip = gameEndedClips[index];
        gameEndedSource.Play();
    }
}
