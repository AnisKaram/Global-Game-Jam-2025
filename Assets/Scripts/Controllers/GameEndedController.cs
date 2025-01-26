using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameEndedController : MonoBehaviour
{
    public GameObject gameWonPanel;
    public GameObject gameOverPanel;

    public Text gameWonCarrotsText;
    public Text gameWonCoinsText;

    public Text gameOverCarrotsText;
    public Text gameOverCoinsText;

    public void TriggerGameWon()
    {
        GameManager.instance.SaveData();
        gameWonPanel.SetActive(true);
        UpdateGameWonUI();
        PauseTimeScale();
    }
    public void TriggerGameOver()
    {
        gameOverPanel.SetActive(true);
        UpdateGameOverUI();
        PauseTimeScale();
    }

    private void UpdateGameWonUI()
    {
        GameManager gameManager = GameManager.instance;
        gameWonCarrotsText.text = $"Carrots Collected: {gameManager.collectiblesInventory.carrots}";
        gameWonCoinsText.text = $"Coins Collected: {gameManager.collectiblesInventory.coins}";
    }
    private void UpdateGameOverUI()
    {
        GameManager gameManager = GameManager.instance;
        gameOverCarrotsText.text = $"Carrots Collected: {gameManager.collectiblesInventory.carrots}";
        gameOverCoinsText.text = $"Coins Collected: {gameManager.collectiblesInventory.coins}";
    }

    private void PauseTimeScale()
    {
        Time.timeScale = 0;
    }
}
