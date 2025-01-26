using UnityEngine;
using System;

public class CoinCollectible : MonoBehaviour, ICollectible
{
    public static event Action CoinCollected;

    public void Collect()
    {
        CoinCollected?.Invoke();
        Destroy();
        PlaySoundEffect();
        PlayParticleEffect();
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }

    public void PlayParticleEffect()
    {
        GameManager.instance.particleEffect.PlayCarrotEffect(transform.position);
    }

    public void PlaySoundEffect()
    {
        GameManager.instance.soundController.PlaySoundEffect(1);
    }
}
