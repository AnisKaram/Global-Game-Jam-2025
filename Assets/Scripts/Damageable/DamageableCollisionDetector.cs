using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageableCollisionDetector : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.TryGetComponent(out IDamageable damageable))
        {
            damageable.Damage();
        }
    }
}