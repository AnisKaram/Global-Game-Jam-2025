using UnityEngine;
using UnityEngine.UI;

public class GameEndedController : MonoBehaviour
{
    #region Fields

    [Header("Game over/won GameObjects")]
    public GameObject gameWonPanel;
    public GameObject gameOverPanel;

    [Header("Game Won Texts")]
    public Text gameWonCarrotsText;
    public Text gameWonCoinsText;

    [Header("Game Over Texts")]
    public Text gameOverCarrotsText;
    public Text gameOverCoinsText;

    #endregion


    #region Public Methods

    public void TriggerGameWon()
    {
        if (Time.timeScale == 1)
        {
            PauseTimeScale();

            GameManager gameManager = GameManager.instance;
            gameManager.SaveData();
            gameManager.soundController.StopSoundtrack();
            gameManager.soundController.PlayGameEndedEffect(0);

            gameWonPanel.SetActive(true);

            UpdateGameWonUI();
        }
    }
    public void TriggerGameOver()
    {
        if (Time.timeScale == 1)
        {
            PauseTimeScale();

            GameManager gameManager = GameManager.instance;
            gameManager.soundController.PlayGameEndedEffect(1);
            gameManager.soundController.StopSoundtrack();

            gameOverPanel.SetActive(true);

            UpdateGameOverUI();
        }
    }

    #endregion


    #region Private Methods

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

    #endregion
}
