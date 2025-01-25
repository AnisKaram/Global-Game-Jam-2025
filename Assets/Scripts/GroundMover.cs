using UnityEngine;

public class GroundMover : MonoBehaviour
{
    public float moveSpeed = 5f;

    private void Update()
    {
        // Move the ground to the left
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
    }
}
