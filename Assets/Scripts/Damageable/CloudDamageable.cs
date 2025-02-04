using UnityEngine;

public class CloudDamageable : MonoBehaviour, IDamageable
{
    private float damage = 10f;
    public void Damage(Vector3 hitPosition)
    {
        Debug.Log($"Cloud Damage, {damage}");
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