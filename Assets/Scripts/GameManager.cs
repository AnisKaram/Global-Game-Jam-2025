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
    public SoundController soundController { get; private set; }

    public GameObject[] levels;

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
        soundController = GetComponentInChildren<SoundController>();

        int levelIndex = PlayerPrefs.GetInt("level.index", 1);
        levels[levelIndex - 1].SetActive(true);
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
        int savedCarrots = PlayerPrefs.GetInt("car.val", 0);
        int savedCoins = PlayerPrefs.GetInt("coi.val", 0);
        PlayerPrefs.SetInt("car.val", collectiblesInventory.carrots + savedCarrots);
        PlayerPrefs.SetInt("coi.val", collectiblesInventory.coins + savedCoins);
        PlayerPrefs.Save();
    }
}