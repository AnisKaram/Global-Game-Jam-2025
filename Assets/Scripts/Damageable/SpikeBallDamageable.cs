using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeBallDamageable : MonoBehaviour, IDamageable
{
    private float damage = 100;
    public void Damage()
    {
        Debug.Log($"SpikeBall Damage {damage}");
    }
}