using UnityEngine;
using UnityEngine.UI;

public class CollectiblesInventoryController : MonoBehaviour
{
    public int coins;
    public int carrots;

    public Text coinsText;
    public Text carrotText;

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

    public void UpdateUI()
    {
        coinsText.text = $"{coins}";
        carrotText.text = $"{carrots}";
    }
}
