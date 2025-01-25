using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float forceAmount = 4f;
    public float rotationSpeed = 80f;
    private Rigidbody2D rb;

    private float maxHeightBoundary;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        CalculateMaxHeightBoundary();
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

        if (IsPlayerExceededMaxBoundary())
        {
            // TODO Gameover
            Debug.Log($"Yes he exceeded");
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

    private void CalculateMaxHeightBoundary()
    {
        Camera camera = Camera.main;
        Vector3 screenPosition = new Vector3(Screen.width, Screen.height, 0f);
        Vector3 worldPosition = camera.ScreenToWorldPoint(screenPosition);
        float offset = 2.5f;
        maxHeightBoundary = worldPosition.y + offset;
    }
    private bool IsPlayerExceededMaxBoundary()
    {
        return Mathf.Abs(transform.position.y) > maxHeightBoundary;
    }
}