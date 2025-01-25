using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthController : MonoBehaviour
{
    public float health = 100f;
    public Text healthText;

    private void Awake()
    {
        health = 100f;
    }
    private void Start()
    {
        UpdateUI();
    }

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

    private void UpdateUI()
    {
        healthText.text = $"{health}";
    }
}