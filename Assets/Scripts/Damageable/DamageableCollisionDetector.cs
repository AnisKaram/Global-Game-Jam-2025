using UnityEngine;

public class DamageableCollisionDetector : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.TryGetComponent(out IDamageable damageable))
        {
            Vector3 hitPosition = collision.transform.position;
            if (collision.contactCount > 0)
            {
                hitPosition = collision.GetContact(0).point;
            }
            damageable.Damage(hitPosition);
        }
    }
}