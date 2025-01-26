using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleEffectController : MonoBehaviour
{
    public ParticleSystem obstacleEffect;
    public ParticleSystem coinEffect;
    public ParticleSystem carrotEffect;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            PlayObstacleImpactEffect(new Vector2(0, 0));
        }
    }
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
}
