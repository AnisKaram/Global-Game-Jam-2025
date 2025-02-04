using UnityEngine;

public class SoundController : MonoBehaviour
{
    #region Fields

    [Header("Audio Clips")]
    public AudioClip[] sfxClips;
    public AudioClip[] gameEndedClips;
    public AudioClip soundtrackClip;

    [Header("Audio Sources")]
    public AudioSource sfxAudioSource;
    public AudioSource gameEndedSource;
    public AudioSource soundtrackSource;

    #endregion


    #region Unity Methods

    private void Start()
    {
        PlaySoundTrack();
    }

    #endregion


    #region Public Methods

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

    #endregion
}