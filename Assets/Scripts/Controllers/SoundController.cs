using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioClip[] sfxClips;
    public AudioClip[] gameEndedClips;
    public AudioClip soundtrackClip;

    public AudioSource sfxAudioSource;
    public AudioSource gameEndedSource;
    public AudioSource soundtrackSource;

    private void Start()
    {
        PlaySoundTrack();
    }

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

    public void PlaySoundTrack()
    {
        if (soundtrackSource == null || soundtrackClip == null)
        {
            return;
        }

        soundtrackSource.clip = soundtrackClip;
        soundtrackSource.loop = true;
        soundtrackSource.Play();
    }
    public void StopSoundtrack()
    {
        soundtrackSource.Stop();
    }
}
