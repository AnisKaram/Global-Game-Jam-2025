using UnityEngine;

public class CloudDamageable : MonoBehaviour, IDamageable
{
    private float damage = 10f;
    public void Damage()
    {
        Debug.Log($"Cloud Damage, {damage}");
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