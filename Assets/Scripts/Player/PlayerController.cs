using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float forceAmount = 4f;
    public float rotationSpeed = 80f;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float vertical = Input.GetAxis("Vertical");

        Vector2 direction = vertical < 0 ? Vector2.down : Vector2.up;
        float gravity = vertical < 0 ? -0.6f : 0.6f;
        float rotationDirection = vertical < 0 ? -1f : 1f;

        if (vertical != 0)
        {
            ChangeGravityScale(gravity);
            ApplyForce(direction: direction, rotationDirection);
        }
    }
    private void FixedUpdate()
    {
        // Limit the angular velocity
        rb.angularVelocity = Mathf.Clamp(rb.angularVelocity, -100f, 100f);
    }

    private void ChangeGravityScale(float gravity)
    {
        rb.gravityScale = gravity;
    }

    private void ApplyForce(Vector2 direction, float rotationDirection)
    {
        // Reset the velocity back to zero
        rb.velocity = Vector2.zero;

        // Apply impulse force
        rb.AddForce(direction * forceAmount, ForceMode2D.Impulse);

        // Rotate the bubble
        rb.AddTorque(rotationDirection * rotationSpeed, ForceMode2D.Impulse);
    }
}