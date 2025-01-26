using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    public Text carrotsText;
    public Text coinsText;

    private void Start()
    {
        carrotsText.text = $"{PlayerPrefs.GetInt("car.val", 0)}";
        coinsText.text = $"{PlayerPrefs.GetInt("coi.val", 0)}";
    }

    public void Level(int level)
    {
        PlayerPrefs.SetInt("level.index", level);
        PlayerPrefs.Save();

        SceneManager.LoadScene("Game");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
