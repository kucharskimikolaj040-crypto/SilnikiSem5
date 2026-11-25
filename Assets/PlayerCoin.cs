using System;
using UnityEngine;

public class PlayerCoin : MonoBehaviour
{
    public int coinForHealthThreashHold = 10;
    private int collectedCoins;
    private PlayerHealth playerHealth;

    public event Action<int> OnCoinAdd;

    public event Action<int> OnCoinInit;

    public void AddCoin(int cointToAdd)
    {
        collectedCoins += cointToAdd;
        CheckForHeal();
        OnCoinAdd?.Invoke(collectedCoins);

    }

    private void CheckForHeal()
    {
        if (collectedCoins >= coinForHealthThreashHold)
        {
            collectedCoins = collectedCoins - coinForHealthThreashHold;
            if (playerHealth != null)
            {
                HealPlayerForCoins();
            }
            else if (TryGetComponent<PlayerHealth>(out PlayerHealth healthComponent))
            {
                playerHealth = healthComponent;
                HealPlayerForCoins();
            }
            else
            {
                Debug.LogError("Health component is not in the same game object as Player Coin");
            }
        }
    }

    private void HealPlayerForCoins()
    {
        playerHealth.AddHealth(playerHealth.maxHealth);
    }

    private void Start()
    {
        OnCoinInit?.Invoke(collectedCoins);
    }

   
}
