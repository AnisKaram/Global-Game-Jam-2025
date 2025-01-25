using UnityEngine;

public class SpikeBallDamageable : MonoBehaviour, IDamageable
{
    private float damage = 50f;
    public void Damage()
    {
        Debug.Log($"SpikeBall Damage {damage}");
        GameManager.instance.playerHealth.ReduceHealth(damage);
        PlayParticleEffect();
        PlaySoundEffect();
    }

    public void PlayParticleEffect()
    {
    }

    public void PlaySoundEffect()
    {
    }
}