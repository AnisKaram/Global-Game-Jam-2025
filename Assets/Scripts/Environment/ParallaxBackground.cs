using UnityEngine;

public class ParallaxBackground : MonoBehaviour
{
    public float parallaxSpeed = 1f;

    private void Update()
    {
        // Move the background to the left
        transform.Translate(Vector2.left * parallaxSpeed * Time.deltaTime);

        // Reset its position
        if (transform.position.x <= -30.5f)
        {
            transform.position = new Vector3(30.5f, transform.position.y, transform.position.z);
        }
    }
}