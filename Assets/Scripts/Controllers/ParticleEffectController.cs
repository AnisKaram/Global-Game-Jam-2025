using UnityEngine;

public class ParticleEffectController : MonoBehaviour
{
    #region Fields

    public ParticleSystem obstacleEffect;
    public ParticleSystem coinEffect;
    public ParticleSystem carrotEffect;

    #endregion


    #region Public Methods

    public void PlayObstacleImpactEffect(Vector2 postion)
    {
        ParticleSystem effectInstance = Instantiate(obstacleEffect, postion, Quaternion.identity);
        effectInstance.Play();
    }

    public void PlayCoinEffect(Vector2 position)
    {
        ParticleSystem effectInstance = Instantiate(coinEffect, position, Quaternion.identity);
        effectInstance.Play();
    }

    public void PlayCarrotEffect(Vector2 position)
    {
        ParticleSystem effectInstance = Instantiate(carrotEffect, position, Quaternion.identity);
        effectInstance.Play();
    }

    #endregion
}