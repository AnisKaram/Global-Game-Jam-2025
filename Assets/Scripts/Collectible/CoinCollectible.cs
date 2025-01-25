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
        PlayerParticleEffect();
        Debug.Log("Coin Collected");
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
