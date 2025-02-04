using UnityEngine;

public class PlayerCollisionDetector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("EndOfLevel"))
        {
            GameManager.instance.gameEnded.TriggerGameWon();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("GameOver"))
        {
            GameManager.instance.gameEnded.TriggerGameOver();
        }
    }
}
