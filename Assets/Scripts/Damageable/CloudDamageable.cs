using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudDamageable : MonoBehaviour, IDamageable
{
    private float damage = 50f;
    public void Damage()
    {
        Debug.Log($"Cloud Damage, {damage}");
        // Apply damage to the player
    }
}