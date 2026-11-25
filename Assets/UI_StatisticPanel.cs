using TMPro;
using UnityEngine;

public class UI_StatisticPanel : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public PlayerCoin playerCoin;
    public TextMeshProUGUI coinText;
    public TextMeshProUGUI healthText;

    private void Awake()
    {
        playerHealth.OnAddHealth += PlayerHealth_OnAddHealth;
        playerHealth.OnHealthInnit += PlayerHealth_OnHealthInnit;
        playerCoin.OnCoinInit += PlayerCoin_OnCoinInit;
        playerCoin.OnCoinAdd += PlayerCoin_OnCoinAdd;
    }

    private void PlayerCoin_OnCoinAdd(int obj)
    {
        ModifyCoinText(obj);
    }

    private void ModifyCoinText(int obj)
    {
        coinText.text = "Coins: " + obj.ToString();
    }

    private void PlayerCoin_OnCoinInit(int obj)
    {
        ModifyCoinText(obj);
    }

    private void PlayerHealth_OnHealthInnit(int health)
    {
        ModifyHealthText(health);
    }

    private void ModifyHealthText(int health)
    {
        healthText.text = "Health: " + health.ToString();
    }

    private void PlayerHealth_OnAddHealth(int health)
    {
        ModifyHealthText(health);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
