using UnityEngine;

public class SunDamageable : MonoBehaviour, IDamageable
{
    private float damage = 75f;

    public void Damage(Vector3 hitPosition)
    {
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
        GameManager.instance.soundController.PlaySoundEffect(0);
    }
}
