using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunDamageable : MonoBehaviour, IDamageable
{
    private float damage = 100f;

    public void Damage()
    {
        Debug.Log($"Sun Damage, {damage}");
    }
}
