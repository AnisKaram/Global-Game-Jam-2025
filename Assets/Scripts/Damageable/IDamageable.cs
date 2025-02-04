using UnityEngine;

public interface IDamageable
{
    public void Damage(Vector3 hitPosition);
    public void PlaySoundEffect();
    public void PlayParticleEffect(Vector3 effectPosition);
}