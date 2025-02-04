using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthController : MonoBehaviour
{
    #region Fields

    public float health = 100f;
    public Text healthText;

    #endregion


    #region Unity Methods

    private void Awake()
    {
        health = 100f;
    }
    private void Start()
    {
        UpdateUI();
    }

    #endregion


    #region Public Methods

    public void ReduceHealth(float damage)
    {
        health -= damage;
        health = Mathf.Clamp(health, 0, 100);

        UpdateUI();

        if (health <= 0)
        {
            GameManager.instance.gameEnded.TriggerGameOver();
        }
    }

    #endregion


    #region Private Methods

    private void UpdateUI()
    {
        healthText.text = $"{health}";
    }

    #endregion
}