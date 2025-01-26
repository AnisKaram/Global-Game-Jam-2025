using UnityEngine;

public class SpikeBallDamageable : MonoBehaviour, IDamageable
{
    private float damage = 50f;
    public void Damage(Vector3 hitPosition)
    {
        Debug.Log($"SpikeBall Damage {damage}");
        GameManager.instance.playerHealth.ReduceHealth(damage);
        PlayParticleEffect(hitPosition);
        PlaySoundEffect();
    }

    public void PlayParticleEffect(Vector3 effectPosition)
    {
        GameManager.instance.particleEffect.PlayObstacleImpactEffect(effectPosition);
    }

    public void PlaySoundEffect()
    {
    }
}