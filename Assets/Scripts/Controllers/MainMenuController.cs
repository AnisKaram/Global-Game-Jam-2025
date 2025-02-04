using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    #region Fields

    [Header("Texts")]
    public Text carrotsText;
    public Text coinsText;

    #endregion


    #region Unity Methods

    private void Start()
    {
        carrotsText.text = $"{PlayerPrefs.GetInt("car.val", 0)}";
        coinsText.text = $"{PlayerPrefs.GetInt("coi.val", 0)}";
    }

    #endregion


    #region Public Methods

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

    #endregion
}