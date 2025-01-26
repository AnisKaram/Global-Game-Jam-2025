using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager m_instance;

    public PlayerHealthController playerHealth { get; private set; }
    public GameEndedController gameEnded { get; private set; }
    public CollectiblesInventoryController collectiblesInventory { get; private set; }
    public ParticleEffectController particleEffect { get; private set; }

    public static GameManager instance => m_instance;

    private void Awake()
    {
        Time.timeScale = 1;

        if (m_instance == null)
        {
            m_instance = this;
        }

        playerHealth = GetComponentInChildren<PlayerHealthController>();
        gameEnded = GetComponentInChildren<GameEndedController>();
        collectiblesInventory = GetComponentInChildren<CollectiblesInventoryController>();
        particleEffect = GetComponentInChildren<ParticleEffectController>();
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void SaveData()
    {
        PlayerPrefs.SetInt("car.val", collectiblesInventory.carrots);
        PlayerPrefs.SetInt("coi.val", collectiblesInventory.coins);
        PlayerPrefs.Save();
    }
}