using UnityEngine;

public class SunDamageable : MonoBehaviour, IDamageable
{
    private float damage = 75f;

    public void Damage()
    {
        Debug.Log($"Sun Damage, {damage}");
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
