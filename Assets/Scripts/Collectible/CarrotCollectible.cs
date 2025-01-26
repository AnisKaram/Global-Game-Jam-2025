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
        PlayParticleEffect();
        Debug.Log($"Carrot Collected");
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
    }
}
