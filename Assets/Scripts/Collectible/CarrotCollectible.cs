using UnityEngine;
using System;

public class CarrotCollectible : MonoBehaviour, ICollectible
{
    public static event Action CarrotCollected;

    public void Collect()
    {
        CarrotCollected?.Invoke();
        Destroy();
        PlaySoundEffect();
        PlayerParticleEffect();
        Debug.Log($"Carrot Collected");
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }

    public void PlayerParticleEffect()
    {
    }

    public void PlaySoundEffect()
    {
    }
}
