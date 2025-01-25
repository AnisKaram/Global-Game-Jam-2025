using UnityEngine;

public class SpikeDamageable : MonoBehaviour, IDamageable
{
    private float damage = 25f;

    public void Damage()
    {
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
