using UnityEngine;
using UnityEngine.UI;

public class CollectiblesInventoryController : MonoBehaviour
{
    #region Fields

    public int coins { get; private set; }
    public int carrots { get; private set; }

    public Text coinsText;
    public Text carrotText;

    #endregion


    #region Unity Methods

    private void OnEnable()
    {
        CarrotCollectible.CarrotCollected += OnCarrotCollected;
        CoinCollectible.CoinCollected += OnCoinCollected;
    }
    private void Start()
    {
        UpdateUI();
    }
    private void OnDisable()
    {
        CarrotCollectible.CarrotCollected -= OnCarrotCollected;
        CoinCollectible.CoinCollected -= OnCoinCollected;
    }

    #endregion


    #region Private Methods

    private void OnCoinCollected()
    {
        coins += 1;
        UpdateUI();
    }

    private void OnCarrotCollected()
    {
        carrots += 1;
        UpdateUI();
    }

    #endregion


    #region Public Methods

    public void UpdateUI()
    {
        coinsText.text = $"{coins}";
        carrotText.text = $"{carrots}";
    }

    #endregion
}